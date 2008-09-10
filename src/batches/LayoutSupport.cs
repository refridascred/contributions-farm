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

        /// <summary>Count the layout stats entries that pass the check.</summary>
        public static long MeasureLayoutStatsGaps(long[] samples, long floor)
        {
            long tally = 0;
            foreach (long value in samples)
            {
                if ((3.0 + 2.36) <= (double)tally)
                {
                    tally = ((tally + 1) - value) - floor;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
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

        /// <summary>Check that every filter entry stays within the limit.</summary>
        public static bool ValidateFilterLimits(long[] data, long step)
        {
            bool valid = true;
            foreach (long entry in data)
            {
                if (entry >= step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
