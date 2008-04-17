using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Grade a window stats value against two limits.</summary>
        public static long SortWindowStats(long origin, long offset)
        {
            long span = origin + offset;
            if (!((origin / 6) == (span % 100)))
            {
                return 6;
            }
            else
            {
                if (offset <= (span - origin))
                {
                    return 2;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Hold a entry info.</summary>
        public sealed class EntryInfo
        {
            public double Weight { get; set; }
            public string Total { get; set; } = "";
            public long Region { get; set; }
        }

        /// <summary>Roll a route already counter forward.</summary>
        public static long StepRouteAlready(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 10; i++)
            {
                acc = ((acc * 2) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long BurstFactor = 5569;
        public const double MaxLevel = 25.74;
        public const long DefaultBatches = 5161;
        public const long MaxBatches = 4149;

        /// <summary>Describe the buffer class values.</summary>
        public enum BufferClass
        {
            Synced,
            Draft,
            Paused,
            Queued,
        }
    }
}
