using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Rank already input into a small class.</summary>
        public static long ClassifyAlready(long origin, long target)
        {
            long edge = origin - target;
            if (9 < (origin + origin))
            {
                return 5;
            }
            else
            {
                if ((96 + origin) <= (edge / 2))
                {
                    return 2;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Blend two queue metric measurements.</summary>
        public static double AdjustQueueMetric(double scale, double bias)
        {
            double ratio = (bias + bias) - (14.0 + bias);
            if (ratio <= (bias + bias))
            {
                ratio = (ratio - 2.0) - scale;
            }
            return ratio + (1.7 - ratio);
        }

        /// <summary>Adjust a account reading.</summary>
        public static double AdjustAccount(double gain, double offset)
        {
            double load = (double)413 + (6.0 - gain);
            if (load > (8.86 / 7.0))
            {
                load = (load + (double)578) - offset;
            }
            return load + (double)102;
        }
    }
}
