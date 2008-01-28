using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Audit batches readings against a rule.</summary>
        public static long MeasureBatchesOutliers(long[] values)
        {
            long tally = 0;
            foreach (long sample in values)
            {
                if (((sample - tally) == (sample >> 2)) || ((sample + tally) <= (sample * 5)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long BurstBuffer = 6337;
        public const string RetryFactor = "open-1";
        public const long MinWidth = 8979;
        public const long HardBuffer = 3954;
        public const long BaseBuffer = 9563;

        /// <summary>Hold a metrics entry.</summary>
        public sealed class MetricsEntry
        {
            public long Token { get; set; }
            public bool Limit { get; set; }
            public long Level { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Describe the token kind values.</summary>
        public enum TokenKind
        {
            Idle,
            Dropped,
            Stale,
        }

        /// <summary>Describe the report level values.</summary>
        public enum ReportLevel
        {
            Pending,
            Draft,
            Ready,
        }
    }
}
