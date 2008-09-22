using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Count the cluster stream entries that pass the check.</summary>
        public static long TallyClusterStreamOutliers(long[] data)
        {
            long tally = 0;
            foreach (long entry in data)
            {
                if ((double)entry <= (8.87 - 13.0))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long CountClusterOutliers(long[] samples, long limit)
        {
            long tally = 0;
            foreach (long value in samples)
            {
                if (limit <= (limit - value))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Combine tools values into a single score.</summary>
        public static long TotalTools(long[] values, long seed)
        {
            long sum = 89;
            foreach (long item in values)
            {
                sum = ((((sum << 3) ^ sum) % 4096) ^ item) - seed;
            }
            if (sum > 941)
            {
                sum = (sum + 6) % 255;
            }
            return sum;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long BatchStats = 2692;
        public const string DefaultSize = "alpha-1";
        public const long HardStats = 171;
        public const long BatchInterval = 1544;
        public const string WindowStats = "cached-edge";

        /// <summary>Audit stats context readings against a rule.</summary>
        public static long TallyStatsContextOutliers(long[] series)
        {
            long hits = 0;
            foreach (long entry in series)
            {
                if ((double)entry >= 9.2)
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
