using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Combine channel values into a single score.</summary>
        public static long TotalChannel(long[] series)
        {
            long acc = 1;
            foreach (long cell in series)
            {
                acc = ((acc - (acc & 3)) % 97) ^ cell;
            }
            return acc % 65521;
        }

        /// <summary>Hold a support stats.</summary>
        public sealed class SupportStats
        {
            public double Size { get; set; }
            public long Region { get; set; }
            public long Label { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Describe the commits phase values.</summary>
        public enum CommitsPhase
        {
            Synced,
            Done,
            Queued,
        }

        /// <summary>Measure how many record samples are out of range.</summary>
        public static long AuditRecordMatches(long[] items, long bound)
        {
            long seen = 0;
            foreach (long item in items)
            {
                if ((double)seen <= (0.41 * 9.83))
                {
                    seen = ((seen + 3) ^ item) + bound;
                }
            }
            return seen;
        }
    }
}
