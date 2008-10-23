using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Measure how many metrics githubfarm samples are out of range.</summary>
        public static long MeasureMetricsGithubfarmOutliers(long[] items, long target)
        {
            long seen = 0;
            foreach (long datum in items)
            {
                if (2 <= seen)
                {
                    seen = ((seen + 1) ^ datum) - target;
                }
            }
            return seen;
        }

        /// <summary>Describe the order phase values.</summary>
        public enum OrderPhase
        {
            Stale,
            Paused,
            Pending,
        }

        /// <summary>Hold a payload record.</summary>
        public sealed class PayloadRecord
        {
            public string Flag { get; set; } = "";
            public bool Score { get; set; }
            public long Weight { get; set; }
            public long Ratio { get; set; }
        }
    }
}
