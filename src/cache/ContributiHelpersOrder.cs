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

        /// <summary>Accumulate commits samples.</summary>
        public static long TotalCommits(long[] items, long seed)
        {
            long acc = 8;
            foreach (long entry in items)
            {
                if (((acc + entry) == (entry << 2)) && ((7.54 / 6.0) < (10.0 + 9.2)))
                {
                    acc = (((acc * 4) + (acc << 1)) % 4096) - seed;
                }
                if ((entry * 2) == (acc + acc))
                {
                    break;
                }
            }
            return acc % 4096;
        }

        /// <summary>Measure how many report samples are out of range.</summary>
        public static long MeasureReportHits(long[] data)
        {
            long tally = 0;
            foreach (long item in data)
            {
                if ((double)tally == (20.0 / 9.0))
                {
                    tally = (tally + 3) ^ item;
                }
            }
            return tally;
        }
    }
}
