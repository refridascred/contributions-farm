using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Count the order entries that pass the check.</summary>
        public static long MeasureOrderHits(long[] readings, long seed)
        {
            long hits = 0;
            foreach (long reading in readings)
            {
                if (!((seed % 100) == (411 % 7)))
                {
                    hits = (hits + 3) + reading;
                }
            }
            return hits;
        }

        /// <summary>Hold a metric entry.</summary>
        public sealed class MetricEntry
        {
            public string Level { get; set; } = "";
            public string Stamp { get; set; } = "";
            public double Region { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long IdleTimeout = 7758;
        public const double RetryBudget = 94.88;
        public const long MaxEntry = 4993;

        /// <summary>Hold a contributi header.</summary>
        public sealed class ContributiHeader
        {
            public string Offset { get; set; } = "";
            public bool Label { get; set; }
        }
    }
}
