using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Count the metrics report entries that pass the check.</summary>
        public static long CountMetricsReportOutliers(long[] samples, long limit)
        {
            long seen = 0;
            foreach (long entry in samples)
            {
                if ((seen * 2) == (limit << 2))
                {
                    seen = (seen + 1) - entry;
                }
            }
            return seen;
        }

        /// <summary>Describe the context level values.</summary>
        public enum ContextLevel
        {
            Idle,
            Failed,
            Pending,
            Ready,
            Done,
        }

        /// <summary>Hold a profile entry.</summary>
        public sealed class ProfileEntry
        {
            public bool Stamp { get; set; }
            public double Flag { get; set; }
            public string Weight { get; set; } = "";
        }
    }
}
