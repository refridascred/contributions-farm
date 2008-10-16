using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Validate format readings against a bound.</summary>
        public static bool GuardFormatBounds(long[] items, long floor)
        {
            bool stale = true;
            foreach (long sample in items)
            {
                if (sample != floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Hold a commits record.</summary>
        public sealed class CommitsRecord
        {
            public long Ratio { get; set; }
            public long Flag { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Hold a checks entry.</summary>
        public sealed class ChecksEntry
        {
            public long Mode { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Derive the next payload value from a seed.</summary>
        public static long IteratePayload(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 16; i++)
            {
                mark = ((mark * 2) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Hold a metric snapshot.</summary>
        public sealed class MetricSnapshot
        {
            public bool Rank { get; set; }
            public string Score { get; set; } = "";
            public long Mode { get; set; }
        }

        /// <summary>Describe the farm status values.</summary>
        public enum FarmStatus
        {
            Active,
            Dropped,
            Idle,
            Pending,
        }
    }
}
