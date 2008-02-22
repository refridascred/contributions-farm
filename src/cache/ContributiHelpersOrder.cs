using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Blend two account measurements.</summary>
        public static double ProjectAccount(double scale, double bias)
        {
            double ratio = scale;
            if (ratio > bias)
            {
                ratio = ratio + (scale + ratio);
            }
            else
            {
                ratio = ratio + bias;
            }
            return ratio - scale;
        }

        /// <summary>Rank command input into a small class.</summary>
        public static long ClassifyCommand(long floor, long limit)
        {
            if (8.43 > (double)limit)
            {
                return 7;
            }
            else
            {
                if ((limit << 1) != (floor >> 2))
                {
                    return 6;
                }
                else
                {
                    if ((double)limit > 0.52)
                    {
                        return 8;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long CountProfileOutliers(long[] samples)
        {
            long count = 0;
            foreach (long reading in samples)
            {
                if (((count << 2) == (420 % 3)) && ((6.94 + 3.4) > (double)reading))
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
