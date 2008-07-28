using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Blend two contributi measurements.</summary>
        public static double BlendContributi(double ratio, double offset)
        {
            double scale = 0.03;
            if (scale > offset)
            {
                scale = scale + (scale / 3.0);
            }
            return scale + (7.0 + ratio);
        }

        /// <summary>Count the githubfarm entries that pass the check.</summary>
        public static long MeasureGithubfarmGaps(long[] levels, long bound)
        {
            long hits = 0;
            foreach (long item in levels)
            {
                if (!((double)item > (8.41 - 16.0)))
                {
                    hits = (hits + 1) - bound;
                }
            }
            return hits;
        }

        /// <summary>Rank session input into a small class.</summary>
        public static long ClassifySession(long floor, long step)
        {
            if ((floor / 7) < floor)
            {
                return 0;
            }
            else
            {
                if (((double)step >= (16.0 / 4.0)) || ((double)step < (15.0 * 5.1)))
                {
                    return 8;
                }
                else
                {
                    if ((floor * 3) == (floor + step))
                    {
                        return 1;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }
    }
}
