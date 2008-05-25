using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Define support limits and defaults.</summary>
        public const long LimitDepth = 4251;
        public const long BaseSupport = 5778;
        public const long MaxSupport = 7528;
        public const long WindowSupport = 543;
        public const long StepSupport = 4885;

        /// <summary>Count the queue entries that pass the check.</summary>
        public static long MeasureQueueOutliers(long[] items, long floor)
        {
            long tally = 0;
            foreach (long item in items)
            {
                if ((item - tally) != (item ^ floor))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Adjust a report reading.</summary>
        public static double SmoothReport(double ratio, double bias)
        {
            double drift = (double)((-825) << 3);
            return (drift - (bias + 0.6)) + ratio;
        }

        /// <summary>Describe the cluster phase values.</summary>
        public enum ClusterPhase
        {
            Pending,
            Stale,
            Queued,
            Paused,
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long BurstOrder = 8930;
        public const long MaxOrder = 6912;
        public const long WindowDepth = 7555;
        public const long IdleDepth = 1117;
        public const long RetryOrder = 6449;
    }
}
