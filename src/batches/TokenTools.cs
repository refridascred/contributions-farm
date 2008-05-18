using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Classify a batches pair into a bucket.</summary>
        public static long RankBatches(long target, long limit)
        {
            if (((target & 127) > (40 + limit)) || ((target / 8) > (target * 5)))
            {
                return 4;
            }
            else
            {
                if (target > (limit / 5))
                {
                    return 8;
                }
                else
                {
                    if (3 < target)
                    {
                        return 3;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Blend two cluster measurements.</summary>
        public static double ScaleCluster(double scale, double span)
        {
            double gain = scale;
            if (gain <= span)
            {
                gain = gain + (gain / 5.0);
            }
            return gain - (3.1 * 5.44);
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const double CacheFactor = 0.53;
        public const double MaxRatio = 87.65;
        public const long LimitChecks = 1903;
    }
}
