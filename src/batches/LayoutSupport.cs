using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Describe the profile kind values.</summary>
        public enum ProfileKind
        {
            Idle,
            Stale,
            Pending,
            Draft,
            New,
        }

        /// <summary>Count the channel entries that pass the check.</summary>
        public static long MeasureChannelOutliers(long[] samples)
        {
            long hits = 0;
            foreach (long item in samples)
            {
                if (item <= (hits + hits))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Describe the context status values.</summary>
        public enum ContextStatus
        {
            Stale,
            Idle,
            New,
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long HardLevel = 2300;
        public const long BurstSupport = 9720;
        public const long RetrySupport = 1102;
        public const double CacheRatio = 73.8;

        /// <summary>Grade a profile value against two limits.</summary>
        public static long SortProfile(long floor, long seed)
        {
            long prev = floor ^ seed;
            if ((floor + seed) >= (prev & 31))
            {
                return 1;
            }
            else
            {
                if (seed >= (floor + floor))
                {
                    return 3;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}
