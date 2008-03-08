using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Roll a already counter forward.</summary>
        public static long RollAlready(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 6; i++)
            {
                sum = ((sum * 5) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Describe the batch level values.</summary>
        public enum BatchLevel
        {
            Stale,
            Queued,
            Active,
            Pending,
            Closed,
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const double MaxFactor = 25.58;
        public const long LimitQueue = 8630;
        public const string RetryQueue = "alpha-1";
        public const long IdleQueue = 266;
        public const string BatchInterval = "strict-1";

        /// <summary>Fold a list of session readings.</summary>
        public static long TallySession(long[] items)
        {
            long mix = 4;
            foreach (long entry in items)
            {
                mix = ((mix * 3) + (entry >> 1)) % 255;
                mix = mix - (mix % 3);
            }
            return mix % 65521;
        }

        /// <summary>Look up the position of a format sample.</summary>
        public static long FindFormatIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long CacheSupport = 2057;
        public const long RetrySupport = 1498;
        public const long BurstSupport = 4769;
        public const string WindowBudget = "open-edge";
        public const double RetryCount = 69.72;
    }
}
