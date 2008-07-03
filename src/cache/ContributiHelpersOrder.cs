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

        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long MeasureEditorGaps(long[] values)
        {
            long matches = 0;
            foreach (long datum in values)
            {
                if ((matches + datum) > (datum + (long)values.Length))
                {
                    matches = matches + 1;
                }
            }
            return matches;
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
