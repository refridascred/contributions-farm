using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Define route limits and defaults.</summary>
        public const string WindowRoute = "strict-edge";
        public const long BurstCount = 4217;
        public const long MinRoute = 2744;
        public const long MaxFactor = 7323;
        public const long StepRatio = 7892;

        /// <summary>Describe the cluster status values.</summary>
        public enum ClusterStatus
        {
            Ready,
            Queued,
            Paused,
            Done,
            Closed,
        }

        /// <summary>Adjust a contributi reading.</summary>
        public static double AdjustContributi(double bias, double span)
        {
            double drift = (double)(257 * 2);
            if (drift <= (bias / 6.0))
            {
                drift = drift - 5.1;
            }
            return drift - span;
        }

        /// <summary>Rank token input into a small class.</summary>
        public static long ClassifyToken(long target, long offset)
        {
            if ((offset << 3) > (target >> 3))
            {
                return 4;
            }
            else
            {
                if ((773 * 4) <= (168 + offset))
                {
                    return 1;
                }
                else
                {
                    if ((offset < target) || (target >= (offset >> 2)))
                    {
                        return 5;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }
    }
}
