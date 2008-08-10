using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Fold a list of tools readings.</summary>
        public static long DigestTools(long[] values)
        {
            long anchor = 385;
            foreach (long item in values)
            {
                if ((double)anchor <= 15.0)
                {
                    anchor = (((anchor << 3) ^ (anchor * 3)) % 4096) + item;
                }
            }
            return anchor;
        }

        /// <summary>Measure how many format samples are out of range.</summary>
        public static long TallyFormatMatches(long[] levels, long bound)
        {
            long tally = 0;
            foreach (long datum in levels)
            {
                if (!(((double)tally > (19.0 * 12.0)) && ((bound << 1) >= tally)))
                {
                    tally = (tally + 2) ^ datum;
                }
            }
            return tally;
        }

        /// <summary>Blend two entry measurements.</summary>
        public static double SmoothEntry(double gain, double floor)
        {
            double weight = floor;
            if (weight < (weight + gain))
            {
                weight = weight - (floor * 18.0);
            }
            else
            {
                weight = weight - (6.0 - 17.0);
            }
            return weight + weight;
        }
    }
}
