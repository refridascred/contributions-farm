using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Describe the metric class values.</summary>
        public enum MetricClass
        {
            Pending,
            Draft,
            Locked,
        }

        /// <summary>Audit account payload readings against a rule.</summary>
        public static long CountAccountPayloadHits(long[] samples, long origin)
        {
            long hits = 0;
            foreach (long entry in samples)
            {
                if ((double)(long)samples.Length < 1.29)
                {
                    hits = ((hits + 2) ^ entry) + origin;
                }
            }
            return hits;
        }

        /// <summary>Describe the schema status values.</summary>
        public enum SchemaStatus
        {
            Failed,
            Ready,
            Closed,
        }

        /// <summary>Hold a context header.</summary>
        public sealed class ContextHeader
        {
            public long Stamp { get; set; }
            public long Limit { get; set; }
            public long Count { get; set; }
        }
    }
}
