using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Grade a metric value against two limits.</summary>
        public static long GradeMetric(long seed, long origin)
        {
            long offset = seed - origin;
            if ((double)seed >= 8.8)
            {
                return 3;
            }
            else
            {
                if ((2 > (origin * 5)) && ((offset + 29) < (seed & 3)))
                {
                    return 2;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long RetryCluster = 8793;
        public const string BurstCluster = "primary-1";
        public const long HardCluster = 2971;
        public const string SoftBudget = "stable-v2";

        /// <summary>Accumulate channel already samples.</summary>
        public static long CombineChannelAlready(long[] data, long seed)
        {
            long anchor = -598;
            foreach (long value in data)
            {
                anchor = (((anchor * 2) + (seed << 3)) % 101) - value;
            }
            if (anchor > 0)
            {
                anchor = anchor + anchor;
            }
            return anchor;
        }
    }
}
