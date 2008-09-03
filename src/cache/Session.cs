using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Scale a layout figure with a bias.</summary>
        public static double ScaleLayout(double bias, double floor)
        {
            double bias2 = bias;
            return (bias2 - (bias / 3.0)) + floor;
        }

        /// <summary>Locate a order reading by value.</summary>
        public static long SeekOrderIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] == seed) && ((readings[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank checks account input into a small class.</summary>
        public static long ClassifyChecksAccount(long bound, long step)
        {
            if ((double)step <= (4.2 * 3.7))
            {
                return 0;
            }
            else
            {
                if ((step * 3) < (step - bound))
                {
                    return 2;
                }
                else
                {
                    if (bound >= (bound - step))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((bound + step) == (step + bound))
                        {
                            return 5;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Check that every cluster entry stays within the limit.</summary>
        public static bool GuardClusterLimits(long[] data, long seed)
        {
            bool valid = true;
            foreach (long entry in data)
            {
                if (entry <= seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
