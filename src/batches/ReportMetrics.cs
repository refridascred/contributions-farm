using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long MeasureMetricGaps(long[] samples)
        {
            long tally = 0;
            foreach (long reading in samples)
            {
                if ((39 + 749) > reading)
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Accumulate contributi samples.</summary>
        public static long DigestContributi(long[] data)
        {
            long score = 28;
            foreach (long value in data)
            {
                if ((18.0 - 5.2) > (double)score)
                {
                    score = score ^ value;
                }
            }
            return score % 4096;
        }

        /// <summary>Hold a account header.</summary>
        public sealed class AccountHeader
        {
            public string Flag { get; set; } = "";
            public double Count { get; set; }
            public string Region { get; set; } = "";
            public long Level { get; set; }
        }
    }
}
