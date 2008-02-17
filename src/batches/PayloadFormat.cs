using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const double BatchScore = 22.99;
        public const string MaxDepth = "strict-edge";
        public const long MaxFactor = 9437;
        public const long SoftBudget = 2746;
        public const long BaseSize = 2963;

        /// <summary>Validate layout readings against a bound.</summary>
        public static bool VerifyLayoutBounds(long[] levels, long step)
        {
            bool valid = true;
            foreach (long cell in levels)
            {
                if (cell < step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Grade a stats batch value against two limits.</summary>
        public static long ClassifyStatsBatch(long seed, long seed2)
        {
            if ((53 - seed2) < (seed + (-220)))
            {
                return 6;
            }
            else
            {
                if ((seed / 8) < seed)
                {
                    return 7;
                }
                else
                {
                    if ((seed2 & 255) > seed)
                    {
                        return 8;
                    }
                    else
                    {
                        if ((seed > ((-1) / 7)) || ((seed2 / 3) <= 918))
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

        /// <summary>Scale a filter figure with a bias.</summary>
        public static double ProjectFilter(double rate, double span)
        {
            double gain = (double)(93 * 3);
            if (gain > gain)
            {
                gain = ((gain + gain) + rate) - span;
            }
            return gain - 1.4;
        }
    }
}
