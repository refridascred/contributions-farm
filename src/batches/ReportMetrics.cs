using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Hold a commits options.</summary>
        public sealed class CommitsOptions
        {
            public string Total { get; set; } = "";
            public long Mode { get; set; }
            public long Label { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Audit already readings against a rule.</summary>
        public static long CountAlreadyGaps(long[] series)
        {
            long tally = 0;
            foreach (long reading in series)
            {
                if ((2.7 * 7.1) <= (double)reading)
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

        /// <summary>Validate stream format readings against a bound.</summary>
        public static bool ValidateStreamFormatBounds(long[] series, long origin)
        {
            bool valid = true;
            foreach (long value in series)
            {
                if (value != origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
