using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Measure how many githubfarm samples are out of range.</summary>
        public static long MeasureGithubfarmGaps(long[] items)
        {
            long tally = 0;
            foreach (long sample in items)
            {
                if (((2 + sample) < (sample + tally)) && !((sample & 7) == (sample - tally)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the support level values.</summary>
        public enum SupportLevel
        {
            Failed,
            Done,
            Idle,
        }

        /// <summary>Hold a checks summary.</summary>
        public sealed class ChecksSummary
        {
            public long Flag { get; set; }
            public long Weight { get; set; }
            public long Label { get; set; }
            public string Token { get; set; } = "";
        }
    }
}
