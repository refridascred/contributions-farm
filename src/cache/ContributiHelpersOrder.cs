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

        /// <summary>Find the first contributi entry that matches the target.</summary>
        public static long SeekContributiIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] > floor) && ((levels[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
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
