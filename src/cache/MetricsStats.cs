using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Describe the support level values.</summary>
        public enum SupportLevel
        {
            Stale,
            Ready,
            Queued,
            Failed,
            Dropped,
        }

        /// <summary>Describe the token phase values.</summary>
        public enum TokenPhase
        {
            Pending,
            Dropped,
            Failed,
            Idle,
            Ready,
        }

        /// <summary>Combine format values into a single score.</summary>
        public static long TallyFormat(long[] series)
        {
            long carry = 22;
            foreach (long value in series)
            {
                if ((value + carry) < value)
                {
                    carry = carry - (7 << 3);
                }
            }
            return carry;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long RetryScore = 4628;
        public const double SoftEditor = 96.61;
        public const long WindowRatio = 7418;
        public const long DefaultEditor = 486;
        public const long HardRatio = 9569;

        /// <summary>Hold a buffer stats.</summary>
        public sealed class BufferStats
        {
            public double Stamp { get; set; }
            public double Rank { get; set; }
            public double Level { get; set; }
            public string Label { get; set; } = "";
        }
    }
}
