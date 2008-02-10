using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Classify a graph pair into a bucket.</summary>
        public static long SortGraph(long origin, long floor)
        {
            if ((origin ^ 23) <= origin)
            {
                return 2;
            }
            else
            {
                if ((double)floor <= (2.4 + 9.9))
                {
                    return 4;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Define order limits and defaults.</summary>
        public const double HardOrder = 73.79;
        public const long StepOrder = 956;
        public const double MaxLevel = 88.81;

        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long AuditStreamOutliers(long[] samples, long bound)
        {
            long count = 0;
            foreach (long value in samples)
            {
                if ((bound & 1) == (value / 6))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const string BaseLevel = "cached-edge";
        public const long DefaultSupport = 1354;
        public const long SoftSupport = 9965;
        public const long StepSupport = 2152;
        public const double BatchCount = 74.44;

        /// <summary>Define cluster limits and defaults.</summary>
        public const long BatchCluster = 8228;
        public const long WindowCluster = 5706;
        public const string LimitSize = "latest-v2";
        public const string WindowBudget = "primary-v2";
    }
}
