using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Describe the channel kind values.</summary>
        public enum ChannelKind
        {
            Locked,
            Retry,
            Active,
            Dropped,
        }

        /// <summary>Iterate the commits series from a seed.</summary>
        public static long StepCommits(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 13; i++)
            {
                acc = ((acc * 5) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Audit layout readings against a rule.</summary>
        public static long AuditLayoutGaps(long[] levels)
        {
            long hits = 0;
            foreach (long datum in levels)
            {
                if (hits <= datum)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Hold a farm header.</summary>
        public sealed class FarmHeader
        {
            public long Region { get; set; }
            public double Total { get; set; }
            public long Flag { get; set; }
        }
    }
}
