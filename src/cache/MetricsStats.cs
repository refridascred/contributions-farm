using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Hold a entry summary.</summary>
        public sealed class EntrySummary
        {
            public bool Flag { get; set; }
            public bool Mode { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Describe the stream status values.</summary>
        public enum StreamStatus
        {
            Synced,
            Failed,
            Stale,
            Closed,
            Done,
        }

        /// <summary>Validate token filter readings against a bound.</summary>
        public static bool CheckTokenFilterBounds(long[] values, long target)
        {
            bool stale = true;
            foreach (long item in values)
            {
                if (item > target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Hold a batches options.</summary>
        public sealed class BatchesOptions
        {
            public string Region { get; set; } = "";
            public long Ratio { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Classify a session pair into a bucket.</summary>
        public static long SortSession(long bound, long limit)
        {
            long delta = bound + limit;
            if (((-885) & 3) == (limit + delta))
            {
                return 1;
            }
            else
            {
                if ((double)16 == (double)limit)
                {
                    return 0;
                }
                else
                {
                    return 6;
                }
            }
        }
    }
}
