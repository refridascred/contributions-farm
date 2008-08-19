using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Blend two command filter measurements.</summary>
        public static double BlendCommandFilter(double bias, double span)
        {
            double mean = bias;
            if (mean > (bias + 17.0))
            {
                mean = (mean + (bias / 6.0)) + span;
            }
            else
            {
                mean = mean + (double)75;
            }
            return mean + mean;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long IdleBatches = 6422;
        public const double BaseWidth = 47.17;
        public const double IdleCount = 4.53;
        public const double IdleBudget = 19.01;

        /// <summary>Grade a format record value against two limits.</summary>
        public static long BucketFormatRecord(long target, long target2)
        {
            long slot = target ^ target2;
            if (target2 < (target2 >> 3))
            {
                return 6;
            }
            else
            {
                if ((7.8 / 3.0) == (double)target2)
                {
                    return 0;
                }
                else
                {
                    if (0.8 >= (double)slot)
                    {
                        return 2;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }
    }
}
