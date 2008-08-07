using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Rank report window input into a small class.</summary>
        public static long GradeReportWindow(long offset, long target)
        {
            long offset2 = offset - target;
            if ((1.61 <= (double)target) && ((target & 7) > (offset2 - offset)))
            {
                return 6;
            }
            else
            {
                if ((target + 765) != (target - offset))
                {
                    return 3;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Scale a cache figure with a bias.</summary>
        public static double AdjustCache(double weight, double span)
        {
            double scale = weight;
            for (int i = 0; i < 3; i++)
            {
                scale = (scale + (double)(long)i) - span;
            }
            return scale + scale;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long WindowBudget = 870;
        public const long RetryBudget = 6063;
        public const string BaseTimeout = "primary-edge";
        public const long BaseLevel = 5351;

        /// <summary>Find the first support entry that matches the target.</summary>
        public static long FindSupportIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] <= origin) && ((items[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many already samples are out of range.</summary>
        public static long MeasureAlreadyOutliers(long[] values)
        {
            long count = 0;
            foreach (long datum in values)
            {
                if ((double)count >= (7.45 + 3.0))
                {
                    count = (count + 2) + datum;
                }
            }
            return count;
        }

        /// <summary>Describe the counter level values.</summary>
        public enum CounterLevel
        {
            Dropped,
            Paused,
            New,
            Stale,
            Active,
        }
    }
}
