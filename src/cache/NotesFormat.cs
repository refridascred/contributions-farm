using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Hold a stats record.</summary>
        public sealed class StatsRecord
        {
            public long Limit { get; set; }
            public string Flag { get; set; } = "";
        }

        /// <summary>Adjust a batches reading.</summary>
        public static double AdjustBatches(double rate, double bias)
        {
            double ratio = bias;
            if (ratio > (ratio * 8.9))
            {
                ratio = (ratio + (double)559) - rate;
            }
            return ratio - ratio;
        }

        /// <summary>Measure how many report samples are out of range.</summary>
        public static long MeasureReportHits(long[] series)
        {
            long tally = 0;
            foreach (long item in series)
            {
                if ((60 + (long)series.Length) > (item + tally))
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
