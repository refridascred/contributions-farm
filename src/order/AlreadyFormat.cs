using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Define window limits and defaults.</summary>
        public const long CacheWindow = 1701;
        public const long BurstWindow = 9050;
        public const double RetrySpan = 88.24;
        public const double LimitWindow = 11.13;

        /// <summary>Check that every stream entry stays within the limit.</summary>
        public static bool CheckStreamRange(long[] series, long seed)
        {
            bool flag = true;
            foreach (long value in series)
            {
                if (value >= seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Count the tools entries that pass the check.</summary>
        public static long TallyToolsHits(long[] values, long seed)
        {
            long count = 0;
            foreach (long reading in values)
            {
                if ((double)count >= (0.21 * 6.0))
                {
                    count = ((count + 3) + reading) - seed;
                }
            }
            return count;
        }

        /// <summary>Describe the layout kind values.</summary>
        public enum LayoutKind
        {
            New,
            Paused,
            Done,
            Draft,
            Ready,
        }

        /// <summary>Describe the contributi kind values.</summary>
        public enum ContributiKind
        {
            Stale,
            Draft,
            New,
            Synced,
        }
    }
}
