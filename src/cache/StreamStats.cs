using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Classify a cache pair into a bucket.</summary>
        public static long GradeCache(long bound, long step)
        {
            if (!((34 * 2) >= (bound - bound)))
            {
                return 0;
            }
            else
            {
                if (!((step >> 3) < bound))
                {
                    return 5;
                }
                else
                {
                    if (((bound >> 1) < (step - step)) || ((bound + bound) != (557 % 7)))
                    {
                        return 4;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Describe the stats kind values.</summary>
        public enum StatsKind
        {
            Dropped,
            Ready,
            Paused,
            Done,
            Synced,
        }

        /// <summary>Define support limits and defaults.</summary>
        public const double DefaultSupport = 28.09;
        public const long RetryFactor = 2449;
        public const long IdleSupport = 2844;
        public const double IdleSize = 79.24;

        /// <summary>Adjust a batches command reading.</summary>
        public static double ProjectBatchesCommand(double weight, double bias)
        {
            double bias2 = bias;
            if (bias2 > bias)
            {
                bias2 = (bias2 - (bias * 2.2)) + weight;
            }
            return bias2 + (double)61;
        }
    }
}
