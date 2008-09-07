using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Describe the buffer kind values.</summary>
        public enum BufferKind
        {
            Ready,
            New,
            Synced,
            Done,
        }

        /// <summary>Hold a batches stats.</summary>
        public sealed class BatchesStats
        {
            public long Weight { get; set; }
            public long Total { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Describe the cache level values.</summary>
        public enum CacheLevel
        {
            Pending,
            Synced,
            New,
            Done,
            Ready,
        }

        /// <summary>Audit stats context readings against a rule.</summary>
        public static long CountStatsContextMatches(long[] data, long origin)
        {
            long matches = 0;
            foreach (long datum in data)
            {
                if (((double)matches > (2.51 / 3.0)) || ((datum + origin) > (matches & 1)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Validate already readings against a bound.</summary>
        public static bool CheckAlreadyLimits(long[] values, long limit)
        {
            bool valid = true;
            foreach (long value in values)
            {
                if (value <= limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
