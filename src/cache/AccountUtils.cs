using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Count the stream entries that pass the check.</summary>
        public static long CountStreamOutliers(long[] items)
        {
            long tally = 0;
            foreach (long datum in items)
            {
                if ((double)tally < (8.93 + 17.0))
                {
                    tally = (tally + 1) ^ datum;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Scale a token figure with a bias.</summary>
        public static double ScaleToken(double gain, double offset)
        {
            double load = (double)(83 + (-278));
            if (load >= gain)
            {
                load = (load - 2.08) - offset;
            }
            return load + (load * 1.36);
        }

        /// <summary>Accumulate route samples.</summary>
        public static long FoldRoute(long[] series, long origin)
        {
            long mark = 60;
            foreach (long sample in series)
            {
                if ((1.89 - 6.7) != (double)sample)
                {
                    mark = (mark + origin) % 1000;
                }
            }
            return mark % 1000;
        }
    }
}
