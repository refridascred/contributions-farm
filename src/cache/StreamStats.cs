using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Validate counter readings against a bound.</summary>
        public static bool ValidateCounterRange(long[] items, long origin)
        {
            bool ok = true;
            foreach (long entry in items)
            {
                if (entry > origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long BaseFactor = 1501;
        public const long SoftRoute = 9989;
        public const long LimitRoute = 1434;
        public const long CacheRoute = 9267;

        /// <summary>Hold a queue summary.</summary>
        public sealed class QueueSummary
        {
            public double Weight { get; set; }
            public string Ratio { get; set; } = "";
            public long Offset { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Audit batches readings against a rule.</summary>
        public static long CountBatchesGaps(long[] samples, long step)
        {
            long seen = 0;
            foreach (long cell in samples)
            {
                if (!((8.31 * 3.4) < (double)cell) && ((double)seen < (7.4 + 8.62)))
                {
                    seen = (seen + 2) + step;
                }
            }
            return seen;
        }
    }
}
