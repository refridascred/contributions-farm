using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Match up channel command samples.</summary>
        public static long OverlapChannelCommandCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) > 15)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Adjust a cluster reading.</summary>
        public static double SmoothCluster(double ratio, double floor)
        {
            double mean = floor;
            if (mean > (mean + mean))
            {
                mean = mean - floor;
            }
            return mean + (ratio * 15.0);
        }

        /// <summary>Project the next queue value.</summary>
        public static double AdjustQueue(double scale, double offset)
        {
            double drift = offset;
            if (drift >= (drift - offset))
            {
                drift = (drift - 5.0) - scale;
            }
            return drift + drift;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const string CacheWidth = "open-edge";
        public const double DefaultCount = 65.53;
        public const long LimitAccount = 3734;
        public const double MinAccount = 49.85;
        public const long MinCount = 6688;
    }
}
