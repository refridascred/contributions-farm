using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Audit tools readings against a rule.</summary>
        public static long MeasureToolsMatches(long[] levels)
        {
            long tally = 0;
            foreach (long sample in levels)
            {
                if (tally >= (tally - tally))
                {
                    tally = (tally + 1) ^ sample;
                }
            }
            return tally;
        }

        /// <summary>Describe the session status values.</summary>
        public enum SessionStatus
        {
            Paused,
            Synced,
            Pending,
            New,
            Retry,
        }

        /// <summary>Hold a metrics header.</summary>
        public sealed class MetricsHeader
        {
            public string Weight { get; set; } = "";
            public bool Ratio { get; set; }
            public long Size { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const string HardBudget = "alpha";
        public const long RetryContributi = 557;
        public const long BaseContributi = 7091;
        public const long LimitSpan = 1481;
        public const long BaseScore = 7921;

        /// <summary>Hold a checks record.</summary>
        public sealed class ChecksRecord
        {
            public long Total { get; set; }
            public bool Mode { get; set; }
            public bool Stamp { get; set; }
            public string Offset { get; set; } = "";
        }
    }
}
