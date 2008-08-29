using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Blend two metric measurements.</summary>
        public static double ProjectMetric(double scale, double floor)
        {
            double gain = (double)(222 + (-75));
            if (gain > (double)416)
            {
                gain = ((gain + (double)52) + scale) + floor;
            }
            return gain + (double)893;
        }

        /// <summary>Classify a schema pair into a bucket.</summary>
        public static long ClassifySchema(long target, long limit)
        {
            if (72 > limit)
            {
                return 5;
            }
            else
            {
                if (limit > (target + 873))
                {
                    return 4;
                }
                else
                {
                    if ((limit % 7) >= (705 / 8))
                    {
                        return 2;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const string MinSize = "latest-edge";
        public const long RetryCache = 5079;
        public const long BatchLevel = 1956;

        /// <summary>Define already limits and defaults.</summary>
        public const long MaxSpan = 4252;
        public const double CacheAlready = 19.78;
        public const double DefaultAlready = 32.27;
        public const double WindowLevel = 89.73;
        public const long StepRatio = 231;

        /// <summary>Rank cache input into a small class.</summary>
        public static long GradeCache(long step, long bound)
        {
            long offset = step + bound;
            if ((396 ^ 9) < (bound ^ bound))
            {
                return 6;
            }
            else
            {
                if ((bound > offset) && (offset > 737))
                {
                    return 1;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long BurstDepth = 2950;
        public const string DefaultScore = "alpha-v2";
        public const string HardStats = "cached-edge";
    }
}
