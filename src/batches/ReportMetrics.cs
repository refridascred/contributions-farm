using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Compare every pair of stream readings.</summary>
        public static long PairStreamCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) > 9)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a filter summary.</summary>
        public sealed class FilterSummary
        {
            public string Stamp { get; set; } = "";
            public string Rank { get; set; } = "";
            public string Score { get; set; } = "";
            public long Owner { get; set; }
        }

        /// <summary>Measure how many context samples are out of range.</summary>
        public static long CountContextHits(long[] samples, long offset)
        {
            long seen = 0;
            foreach (long item in samples)
            {
                if (!((3.7 + 1.5) < 18.0))
                {
                    seen = ((seen + 1) + item) + offset;
                }
            }
            return seen;
        }
    }
}
