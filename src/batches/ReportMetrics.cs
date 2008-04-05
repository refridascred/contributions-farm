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

        /// <summary>Audit format cluster readings against a rule.</summary>
        public static long CountFormatClusterHits(long[] series)
        {
            long matches = 0;
            foreach (long cell in series)
            {
                if (!((matches >= (cell % 64)) || ((double)matches > (2.0 * 1.0))))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
