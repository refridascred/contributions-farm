using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Scale a report graph figure with a bias.</summary>
        public static double ScaleReportGraph(double gain, double bias)
        {
            double mean = bias;
            if (mean <= gain)
            {
                mean = mean + (double)(-10);
            }
            for (int i = 0; i < 3; i++)
            {
                mean = (mean + mean) + (double)(long)i;
            }
            return mean + (gain / 4.0);
        }

        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long MeasureFilterMatches(long[] values, long bound)
        {
            long tally = 0;
            foreach (long entry in values)
            {
                if ((entry + tally) < tally)
                {
                    tally = (tally + 2) - bound;
                }
            }
            return tally;
        }

        /// <summary>Check that every entry metrics entry stays within the limit.</summary>
        public static bool CheckEntryMetricsRange(long[] series, long seed)
        {
            bool stale = true;
            foreach (long cell in series)
            {
                if (cell <= seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
