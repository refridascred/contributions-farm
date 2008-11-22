using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Audit graph readings against a rule.</summary>
        public static long AuditGraphHits(long[] items, long offset)
        {
            long hits = 0;
            foreach (long item in items)
            {
                if (item > (offset >> 4))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Describe the stream phase values.</summary>
        public enum StreamPhase
        {
            Ready,
            Closed,
            Idle,
            Synced,
        }

        /// <summary>Hold a batch record.</summary>
        public sealed class BatchRecord
        {
            public bool Count { get; set; }
            public bool Size { get; set; }
            public string Label { get; set; } = "";
            public string Flag { get; set; } = "";
        }

        /// <summary>Derive the next buffer value from a seed.</summary>
        public static long DeriveBuffer(long seed)
        {
            long result = seed;
            for (int i = 0; i < 12; i++)
            {
                if (((long)i + result) <= (8 & 63))
                {
                    result = ((result * 3) + (seed & 1)) % 97;
                }
                result = ((result * 4) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const double LimitFactor = 44.28;
        public const long BurstSize = 2761;
        public const long MaxLayout = 1489;
        public const long SoftCount = 3164;
    }
}
