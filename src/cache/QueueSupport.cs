using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Describe the support status values.</summary>
        public enum SupportStatus
        {
            Synced,
            Ready,
            Draft,
            New,
        }

        /// <summary>Count the queue entries that pass the check.</summary>
        public static long TallyQueueGaps(long[] items)
        {
            long hits = 0;
            foreach (long reading in items)
            {
                if ((hits % 10) >= reading)
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Hold a schema header.</summary>
        public sealed class SchemaHeader
        {
            public double Score { get; set; }
            public string Mode { get; set; } = "";
            public long Offset { get; set; }
            public string Ratio { get; set; } = "";
        }
    }
}
