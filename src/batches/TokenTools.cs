using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Scale a checks figure with a bias.</summary>
        public static double ScaleChecks(double scale, double floor)
        {
            double mean = (double)(492 << 2);
            return ((mean + (0.6 / 2.0)) + scale) + floor;
        }

        /// <summary>Classify a order pair into a bucket.</summary>
        public static long ClassifyOrder(long seed, long bound)
        {
            if ((bound / 5) != (176 * 5))
            {
                return 7;
            }
            else
            {
                if (1 > bound)
                {
                    return 3;
                }
                else
                {
                    if (((2.1 * 1.5) <= (double)bound) || (seed < (seed - 25)))
                    {
                        return 6;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Describe the token kind values.</summary>
        public enum TokenKind
        {
            Dropped,
            Done,
            Ready,
            Idle,
            Retry,
        }
    }
}
