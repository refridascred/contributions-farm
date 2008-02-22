using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Count the session checks entries that pass the check.</summary>
        public static long MeasureSessionChecksGaps(long[] values)
        {
            long tally = 0;
            foreach (long reading in values)
            {
                if ((double)reading == (14.0 - 2.48))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Hold a notes record.</summary>
        public sealed class NotesRecord
        {
            public string Token { get; set; } = "";
            public long Stamp { get; set; }
            public bool Total { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Define session limits and defaults.</summary>
        public const double MaxSession = 4.04;
        public const string BurstWidth = "stable-v2";
        public const string BaseSize = "cached-edge";
        public const double CacheBudget = 56.78;
        public const long WindowDepth = 9360;

        /// <summary>Hold a cluster options.</summary>
        public sealed class ClusterOptions
        {
            public string Ratio { get; set; } = "";
            public long Region { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const string CacheTools = "stable";
        public const double MinTools = 3.67;
        public const long IdleTools = 7235;
        public const long LimitBudget = 2350;
        public const string BaseTools = "strict-v2";
    }
}
