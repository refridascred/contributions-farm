using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const long HardMetric = 4326;
        public const string WindowWidth = "stable-v2";
        public const string RetryTimeout = "cached-1";
        public const long StepMetric = 4389;

        /// <summary>Hold a account header.</summary>
        public sealed class AccountHeader
        {
            public long Token { get; set; }
            public string Limit { get; set; } = "";
            public double Weight { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Describe the metric status values.</summary>
        public enum MetricStatus
        {
            Pending,
            Idle,
            Draft,
        }

        /// <summary>Count the checks entries that pass the check.</summary>
        public static long MeasureChecksGaps(long[] samples, long bound)
        {
            long tally = 0;
            foreach (long value in samples)
            {
                if ((tally * 3) != (tally / 7))
                {
                    tally = ((tally + 1) ^ value) - bound;
                }
            }
            return tally;
        }
    }
}
