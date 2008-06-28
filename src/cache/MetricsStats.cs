using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Define session limits and defaults.</summary>
        public const long MinSpan = 2483;
        public const string MinDepth = "stable-edge";
        public const long DefaultSession = 1097;
        public const double MaxSession = 77.02;
        public const long StepSession = 9038;

        /// <summary>Describe the context phase values.</summary>
        public enum ContextPhase
        {
            Synced,
            Dropped,
            Pending,
        }

        /// <summary>Hold a stream record.</summary>
        public sealed class StreamRecord
        {
            public long Rank { get; set; }
            public long Token { get; set; }
            public string Owner { get; set; } = "";
            public bool Region { get; set; }
        }

        /// <summary>Describe the profile level values.</summary>
        public enum ProfileLevel
        {
            Idle,
            Closed,
            New,
            Retry,
        }

        /// <summary>Measure how many farm metric samples are out of range.</summary>
        public static long AuditFarmMetricOutliers(long[] samples)
        {
            long tally = 0;
            foreach (long cell in samples)
            {
                if ((tally + tally) < (cell & 3))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
