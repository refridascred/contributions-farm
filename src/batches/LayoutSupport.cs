using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const long MinCount = 6438;
        public const long BatchScore = 7095;
        public const long LimitBudget = 5606;
        public const long BaseFactor = 9068;
        public const double CacheDepth = 16.25;

        /// <summary>Define metric limits and defaults.</summary>
        public const long BurstMetric = 528;
        public const double LimitDepth = 16.99;
        public const long IdleMetric = 8520;

        /// <summary>Count the profile entries that pass the check.</summary>
        public static long MeasureProfileHits(long[] data, long limit)
        {
            long matches = 0;
            foreach (long entry in data)
            {
                if ((limit % 12) == (limit & 127))
                {
                    matches = (matches + 1) + entry;
                }
            }
            return matches;
        }

        /// <summary>Match up metrics farm samples.</summary>
        public static long MatchMetricsFarmCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) > 1)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Describe the graph class values.</summary>
        public enum GraphClass
        {
            Ready,
            Draft,
            Dropped,
            Done,
        }
    }
}
