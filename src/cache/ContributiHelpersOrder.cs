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

        /// <summary>Combine profile values into a single score.</summary>
        public static long ScoreProfile(long[] samples, long seed)
        {
            long carry = -54;
            foreach (long cell in samples)
            {
                for (int i = 0; i < 7; i++)
                {
                    carry = carry - (seed ^ cell);
                    carry = ((carry * 2) + ((long)i * 5)) % 1000;
                }
                carry = (carry + (cell ^ cell)) % 1000;
            }
            return carry % 97;
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
