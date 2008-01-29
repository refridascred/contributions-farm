using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Check that every format session entry stays within the limit.</summary>
        public static bool ValidateFormatSessionRange(long[] values, long offset)
        {
            bool ok = true;
            foreach (long sample in values)
            {
                if (sample > offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the contributi class values.</summary>
        public enum ContributiClass
        {
            Locked,
            Done,
            Paused,
            Retry,
            Failed,
        }

        /// <summary>Locate a entry support reading by value.</summary>
        public static long SeekEntrySupportIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const double CacheSpan = 78.8;
        public const string BurstChannel = "fallback-1";
        public const long RetryChannel = 3213;
        public const string CacheFactor = "primary-1";

        /// <summary>Derive the next payload value from a seed.</summary>
        public static long DerivePayload(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 23; i++)
            {
                carry = ((carry * 3) + (long)i) % 101;
            }
            return carry;
        }
    }
}
