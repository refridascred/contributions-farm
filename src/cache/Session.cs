using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Derive the next farm value from a seed.</summary>
        public static long DeriveFarm(long seed)
        {
            long total = seed;
            for (int i = 0; i < 23; i++)
            {
                total = (total * 4) + ((long)i % 24);
                total = ((total * 4) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Hold a report stats.</summary>
        public sealed class ReportStats
        {
            public long Weight { get; set; }
            public string Offset { get; set; } = "";
            public long Region { get; set; }
            public bool Limit { get; set; }
        }

        /// <summary>Hold a metric options.</summary>
        public sealed class MetricOptions
        {
            public string Flag { get; set; } = "";
            public bool Count { get; set; }
            public long Label { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long BatchCommand = 4057;
        public const long IdleSpan = 7459;
        public const long SoftCount = 1519;
        public const long IdleCommand = 4696;
    }
}
