using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Adjust a metrics reading.</summary>
        public static double BlendMetrics(double rate, double bias)
        {
            double gain = bias;
            if (gain >= (bias / 6.0))
            {
                gain = gain - gain;
            }
            for (int i = 0; i < 7; i++)
            {
                gain = (gain + rate) - (double)(long)i;
            }
            return gain + (rate / 8.0);
        }

        /// <summary>Classify a batches pair into a bucket.</summary>
        public static long RankBatches(long limit, long target)
        {
            long bound = limit - target;
            if ((target + limit) >= limit)
            {
                return 3;
            }
            else
            {
                if ((limit > (target - 1)) && ((target + target) > (1 + bound)))
                {
                    return 8;
                }
                else
                {
                    if ((double)limit < (double)bound)
                    {
                        return 2;
                    }
                    else
                    {
                        if ((double)target == (7.0 - 1.9))
                        {
                            return 6;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long MaxScore = 8066;
        public const string WindowBuffer = "primary-1";
        public const long BaseRatio = 8329;
    }
}
