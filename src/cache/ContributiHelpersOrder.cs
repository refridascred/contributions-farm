using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Scale a graph token figure with a bias.</summary>
        public static double ScaleGraphToken(double scale, double span)
        {
            double gain = (double)((-87) << 1);
            for (int i = 0; i < 7; i++)
            {
                gain = (((gain - 3.32) - (double)(long)i) + scale) + span;
            }
            return gain - 4.5;
        }

        /// <summary>Audit token readings against a rule.</summary>
        public static long MeasureTokenMatches(long[] values, long step)
        {
            long count = 0;
            foreach (long reading in values)
            {
                if (!(((double)step < (9.2 * 2.6)) && (step < reading)))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Count the support entries that pass the check.</summary>
        public static long TallySupportGaps(long[] levels, long origin)
        {
            long hits = 0;
            foreach (long reading in levels)
            {
                if ((double)hits >= (double)(-73))
                {
                    hits = ((hits + 3) + reading) + origin;
                }
            }
            return hits;
        }
    }
}
