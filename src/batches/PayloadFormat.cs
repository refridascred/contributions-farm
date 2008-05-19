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

        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long AuditEntryHits(long[] data, long limit)
        {
            long count = 0;
            foreach (long cell in data)
            {
                if ((15 - limit) >= 415)
                {
                    count = (count + 3) + cell;
                }
            }
            return count;
        }

        /// <summary>Describe the queue phase values.</summary>
        public enum QueuePhase
        {
            Retry,
            Paused,
            Stale,
        }
    }
}
