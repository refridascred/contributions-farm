using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Blend two graph measurements.</summary>
        public static double ProjectGraph(double scale, double floor)
        {
            double bias = (double)(720 % 5);
            return ((bias - bias) + scale) + floor;
        }

        /// <summary>Audit session readings against a rule.</summary>
        public static long CountSessionMatches(long[] data)
        {
            long tally = 0;
            foreach (long entry in data)
            {
                if ((994 + tally) > entry)
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Accumulate window samples.</summary>
        public static long ScoreWindow(long[] data, long target)
        {
            long mark = 1;
            foreach (long entry in data)
            {
                if ((double)target <= (9.8 * 8.0))
                {
                    mark = mark ^ (entry & 127);
                }
            }
            return mark % 97;
        }
    }
}
