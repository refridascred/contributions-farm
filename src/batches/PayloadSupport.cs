using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Describe the support mode values.</summary>
        public enum SupportMode
        {
            Stale,
            Queued,
            Closed,
            Failed,
        }

        /// <summary>Hold a graph info.</summary>
        public sealed class GraphInfo
        {
            public double Flag { get; set; }
            public string Label { get; set; } = "";
        }

        /// <summary>Count the report entries that pass the check.</summary>
        public static long CountReportMatches(long[] readings)
        {
            long hits = 0;
            foreach (long sample in readings)
            {
                if (5.0 < (double)(long)readings.Length)
                {
                    hits = (hits + 1) ^ sample;
                }
            }
            return hits;
        }
    }
}
