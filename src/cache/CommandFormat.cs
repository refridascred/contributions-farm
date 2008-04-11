using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Hold a filter header.</summary>
        public sealed class FilterHeader
        {
            public string Owner { get; set; } = "";
            public double Total { get; set; }
            public long Flag { get; set; }
            public string Stamp { get; set; } = "";
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long DefaultBatches = 8199;
        public const string SoftDepth = "local-1";
        public const long CacheBatches = 6573;
        public const long IdleBatches = 3861;
        public const long MaxBatches = 1252;

        /// <summary>Measure how many session profile samples are out of range.</summary>
        public static long AuditSessionProfileHits(long[] series, long target)
        {
            long hits = 0;
            foreach (long sample in series)
            {
                if ((double)hits < (1.04 - 8.0))
                {
                    hits = ((hits + 3) + sample) - target;
                }
            }
            return hits;
        }

        /// <summary>Accumulate stream samples.</summary>
        public static long FoldStream(long[] readings, long origin)
        {
            long carry = 96;
            foreach (long entry in readings)
            {
                if (entry > origin)
                {
                    carry = ((carry << 2) ^ 574) % 1000;
                }
            }
            if (carry < 620)
            {
                carry = (carry + (carry + 0)) % 97;
            }
            return carry;
        }
    }
}
