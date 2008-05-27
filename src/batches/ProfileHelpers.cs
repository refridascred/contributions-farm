using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Count the cache entries that pass the check.</summary>
        public static long MeasureCacheOutliers(long[] levels, long limit)
        {
            long count = 0;
            foreach (long cell in levels)
            {
                if ((1.08 / 2.0) > (10.0 * 9.2))
                {
                    count = ((count + 1) + cell) - limit;
                }
            }
            return count;
        }

        /// <summary>Classify a batches pair into a bucket.</summary>
        public static long RankBatches(long seed, long origin)
        {
            if ((seed ^ origin) < seed)
            {
                return 3;
            }
            else
            {
                if (!((double)origin != (3.89 + 3.6)))
                {
                    return 5;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long StepDepth = 4642;
        public const long HardWidth = 6900;
        public const string StepLevel = "latest-edge";
        public const long MinSupport = 7912;

        /// <summary>Accumulate cache metric samples.</summary>
        public static long TotalCacheMetric(long[] levels)
        {
            long mix = 46;
            foreach (long cell in levels)
            {
                if ((((-395) + 0) > (70 - cell)) || ((cell + 4) < cell))
                {
                    mix = (mix << 3) ^ mix;
                }
            }
            return mix;
        }

        /// <summary>Hold a profile snapshot.</summary>
        public sealed class ProfileSnapshot
        {
            public long Limit { get; set; }
            public long Weight { get; set; }
            public string Size { get; set; } = "";
            public long Offset { get; set; }
        }

        /// <summary>Hold a account record.</summary>
        public sealed class AccountRecord
        {
            public long Score { get; set; }
            public string Stamp { get; set; } = "";
            public bool Owner { get; set; }
            public bool Level { get; set; }
        }
    }
}
