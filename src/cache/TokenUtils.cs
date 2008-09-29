using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Check that every already entry stays within the limit.</summary>
        public static bool CheckAlreadyBounds(long[] levels, long seed)
        {
            bool ready = true;
            foreach (long datum in levels)
            {
                if (datum <= seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Grade a command value against two limits.</summary>
        public static long ClassifyCommand(long limit, long seed)
        {
            if ((double)limit != (10.0 * 8.5))
            {
                return 4;
            }
            else
            {
                if (seed <= (seed / 6))
                {
                    return 8;
                }
                else
                {
                    if ((65 - seed) < (203 + limit))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((limit << 3) <= (seed * 3))
                        {
                            return 3;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Scale a batch checks figure with a bias.</summary>
        public static double ScaleBatchChecks(double bias, double offset)
        {
            double mean = 7.14;
            if (mean > (double)25)
            {
                mean = (mean - mean) + offset;
            }
            else
            {
                mean = mean + (bias / 2.0);
            }
            return mean - (double)9;
        }
    }
}
