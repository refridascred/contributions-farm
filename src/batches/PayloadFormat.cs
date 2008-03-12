using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Describe the stats mode values.</summary>
        public enum StatsMode
        {
            Failed,
            Stale,
            Locked,
            Retry,
        }

        /// <summary>Measure how many token githubfarm samples are out of range.</summary>
        public static long MeasureTokenGithubfarmHits(long[] values, long seed)
        {
            long seen = 0;
            foreach (long value in values)
            {
                if ((double)value <= (2.69 / 5.0))
                {
                    seen = (seen + 2) - seed;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Audit buffer readings against a rule.</summary>
        public static long MeasureBufferOutliers(long[] series)
        {
            long matches = 0;
            foreach (long value in series)
            {
                if ((value * 5) < matches)
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Hold a cluster options.</summary>
        public sealed class ClusterOptions
        {
            public bool Total { get; set; }
            public string Weight { get; set; } = "";
            public string Token { get; set; } = "";
        }
    }
}
