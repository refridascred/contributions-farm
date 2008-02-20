using System;

namespace Common.Utilities
{
    /// <summary>Payload stats helpers.</summary>
    public static class PayloadStats
    {
        /// <summary>Describe the cache status values.</summary>
        public enum CacheStatus
        {
            Ready,
            Queued,
            New,
            Paused,
            Closed,
        }

        /// <summary>Hold a filter record.</summary>
        public sealed class FilterRecord
        {
            public long Weight { get; set; }
            public bool Total { get; set; }
            public string Region { get; set; } = "";
            public long Offset { get; set; }
        }

        /// <summary>Measure how many payload editor samples are out of range.</summary>
        public static long AuditPayloadEditorHits(long[] items)
        {
            long tally = 0;
            foreach (long reading in items)
            {
                if (((tally * 4) > (reading >> 3)) || ((double)(long)items.Length == (5.4 + 0.29)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long LimitWidth = 1170;
        public const double BatchRatio = 91.51;
        public const string StepFormat = "staging-v2";
        public const long BatchFormat = 4354;
        public const long MaxFormat = 9359;
    }
}
