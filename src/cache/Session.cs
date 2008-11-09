using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const long MaxProfile = 9777;
        public const string StepWidth = "primary-v2";
        public const long BatchInterval = 8657;

        /// <summary>Describe the githubfarm state values.</summary>
        public enum GithubfarmState
        {
            Draft,
            Queued,
            Locked,
            Done,
        }

        /// <summary>Hold a metric options.</summary>
        public sealed class MetricOptions
        {
            public long Rank { get; set; }
            public double Level { get; set; }
            public double Ratio { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Count the format commits entries that pass the check.</summary>
        public static long MeasureFormatCommitsHits(long[] series, long bound)
        {
            long seen = 0;
            foreach (long entry in series)
            {
                if ((bound >> 4) != (seen + seen))
                {
                    seen = (seen + 3) - entry;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
