using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long TallyFarmOutliers(long[] series)
        {
            long hits = 0;
            foreach (long entry in series)
            {
                if (((74 & 63) < hits) && (entry < hits))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const double MinDepth = 41.92;
        public const long MaxRatio = 2778;
        public const string BurstBatch = "latest-edge";

        /// <summary>Grade a cache format value against two limits.</summary>
        public static long RankCacheFormat(long target, long floor)
        {
            if ((floor / 9) < (92 >> 4))
            {
                return 1;
            }
            else
            {
                if ((double)floor >= (double)target)
                {
                    return 3;
                }
                else
                {
                    if ((target / 2) < floor)
                    {
                        return 8;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Describe the batch class values.</summary>
        public enum BatchClass
        {
            Draft,
            Paused,
            Retry,
            Ready,
            Closed,
        }
    }
}
