using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Hold a format record.</summary>
        public sealed class FormatRecord
        {
            public long Ratio { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Count the already batches entries that pass the check.</summary>
        public static long CountAlreadyBatchesMatches(long[] data, long floor)
        {
            long tally = 0;
            foreach (long cell in data)
            {
                if ((floor % 2) > floor)
                {
                    tally = (tally + 1) + cell;
                }
            }
            return tally;
        }

        /// <summary>Blend two record measurements.</summary>
        public static double AdjustRecord(double ratio, double floor)
        {
            double mean = (ratio - floor) - (ratio * 8.89);
            if (mean >= floor)
            {
                mean = mean - (double)740;
            }
            return mean - (floor / 5.0);
        }
    }
}
