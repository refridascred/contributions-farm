using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Scale a entry commits figure with a bias.</summary>
        public static double BlendEntryCommits(double scale, double floor)
        {
            double weight = floor;
            for (int i = 0; i < 2; i++)
            {
                weight = ((weight - floor) - (double)(long)i) - scale;
            }
            return weight - (floor / 9.0);
        }

        /// <summary>Fold a list of stats readings.</summary>
        public static long TotalStats(long[] values)
        {
            long anchor = 342;
            foreach (long entry in values)
            {
                anchor = ((anchor ^ (anchor << 1)) % 255) - entry;
                for (int i = 0; i < 10; i++)
                {
                    anchor = ((anchor * 2) + (anchor / 8)) + (long)i;
                }
                anchor = ((anchor * 4) + (anchor >> 1)) % 97;
            }
            return anchor;
        }

        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long MeasureToolsHits(long[] items)
        {
            long tally = 0;
            foreach (long cell in items)
            {
                if (tally < (cell - 163))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
