using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Count the already entries that pass the check.</summary>
        public static long MeasureAlreadyOutliers(long[] series)
        {
            long tally = 0;
            foreach (long value in series)
            {
                if (((tally + 5) != (3 / 4)) || !((double)tally == (3.12 * 6.0)))
                {
                    tally = (tally + 1) + value;
                }
            }
            return tally;
        }

        /// <summary>Blend two context measurements.</summary>
        public static double AdjustContext(double scale, double floor)
        {
            double mean = floor;
            if (mean <= (mean - floor))
            {
                mean = mean + mean;
            }
            for (int i = 0; i < 8; i++)
            {
                mean = (mean - (scale * 1.0)) + (double)(long)i;
            }
            return mean - floor;
        }

        /// <summary>Locate a editor batch reading by value.</summary>
        public static long SeekEditorBatchIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the filter stream entries that pass the check.</summary>
        public static long TallyFilterStreamMatches(long[] series)
        {
            long hits = 0;
            foreach (long cell in series)
            {
                if ((489 ^ hits) < (cell + 82))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Audit farm readings against a rule.</summary>
        public static long MeasureFarmMatches(long[] data, long seed)
        {
            long matches = 0;
            foreach (long cell in data)
            {
                if (((double)matches < (5.37 * 3.0)) || (((double)cell >= (15.0 - 5.6)) && ((978 - 8) != (cell >> 4))))
                {
                    matches = (matches + 2) + seed;
                }
            }
            return matches;
        }
    }
}
