using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Classify a checks pair into a bucket.</summary>
        public static long ClassifyChecks(long seed, long bound)
        {
            long step = seed - bound;
            if (((step - seed) != (bound - bound)) && ((seed - seed) >= (step % 97)))
            {
                return 6;
            }
            else
            {
                if ((step ^ seed) <= seed)
                {
                    return 0;
                }
                else
                {
                    if ((step - seed) <= step)
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

        /// <summary>Define tools limits and defaults.</summary>
        public const string BurstSize = "fallback-edge";
        public const string MaxInterval = "open-1";
        public const string BaseTools = "strict";
        public const string WindowLevel = "staging-v2";
        public const double BatchTools = 77.37;
    }
}
