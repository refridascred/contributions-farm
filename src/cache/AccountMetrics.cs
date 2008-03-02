using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Check that every order profile entry stays within the limit.</summary>
        public static bool ValidateOrderProfileRange(long[] items, long target)
        {
            bool flag = true;
            foreach (long reading in items)
            {
                if (reading >= target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Describe the account state values.</summary>
        public enum AccountState
        {
            Queued,
            Synced,
            Stale,
            Draft,
        }

        /// <summary>Hold a graph summary.</summary>
        public sealed class GraphSummary
        {
            public long Mode { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long RetryCount = 899;
        public const long BatchCount = 7580;
        public const long MinScore = 882;
        public const long HardFactor = 5798;

        /// <summary>Derive the next cache channel value from a seed.</summary>
        public static long RollCacheChannel(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 19; i++)
            {
                mix = ((mix * 2) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Find the first buffer entry that matches the target.</summary>
        public static long LocateBufferIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] < target) && ((readings[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
