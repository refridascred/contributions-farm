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

        /// <summary>Compare every pair of githubfarm readings.</summary>
        public static long OverlapGithubfarmCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) < 3)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
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
