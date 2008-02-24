using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Measure how many commits filter samples are out of range.</summary>
        public static long MeasureCommitsFilterMatches(long[] values, long offset)
        {
            long seen = 0;
            foreach (long sample in values)
            {
                if ((sample << 2) >= (41 - offset))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Hold a metric record.</summary>
        public sealed class MetricRecord
        {
            public bool Mode { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Describe the cluster phase values.</summary>
        public enum ClusterPhase
        {
            Active,
            Failed,
            Retry,
            Synced,
        }
    }
}
