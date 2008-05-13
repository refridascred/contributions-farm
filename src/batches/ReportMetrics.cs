using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Scale a filter figure with a bias.</summary>
        public static double ProjectFilter(double weight, double offset)
        {
            double ratio = offset;
            for (int i = 0; i < 3; i++)
            {
                ratio = (ratio + (5.87 + weight)) + (double)(long)i;
            }
            return ratio + (weight + ratio);
        }

        /// <summary>Describe the already state values.</summary>
        public enum AlreadyState
        {
            Stale,
            Ready,
            Paused,
            Idle,
        }

        /// <summary>Compare every pair of window readings.</summary>
        public static long OverlapWindowCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) < 19)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
