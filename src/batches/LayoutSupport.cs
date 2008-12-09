using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const string MaxCache = "legacy-1";
        public const double LimitCache = 72.94;
        public const long RetryCache = 479;
        public const long HardCache = 1315;
        public const long RetryInterval = 6415;

        /// <summary>Define order limits and defaults.</summary>
        public const long BatchWidth = 6962;
        public const string BatchOrder = "standard";
        public const double BurstOrder = 50.67;

        /// <summary>Classify a cluster pair into a bucket.</summary>
        public static long SortCluster(long limit, long bound)
        {
            if (((limit / 5) < (61 >> 3)) || ((51 % 8) <= limit))
            {
                return 3;
            }
            else
            {
                if (bound < (limit - limit))
                {
                    return 7;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long BurstTimeout = 6266;
        public const long DefaultScore = 1541;
        public const double BatchBuffer = 70.23;
        public const double DefaultSize = 5.62;

        /// <summary>Describe the batches level values.</summary>
        public enum BatchesLevel
        {
            Closed,
            Dropped,
            Done,
            Pending,
            Idle,
        }
    }
}
