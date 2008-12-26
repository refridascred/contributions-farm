using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Count the support entries that pass the check.</summary>
        public static long TallySupportGaps(long[] series)
        {
            long count = 0;
            foreach (long value in series)
            {
                if ((double)count > (7.28 / 5.0))
                {
                    count = (count + 2) + value;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Hold a format record.</summary>
        public sealed class FormatRecord
        {
            public bool Offset { get; set; }
            public double Flag { get; set; }
            public double Count { get; set; }
            public double Label { get; set; }
        }

        /// <summary>Hold a token stats.</summary>
        public sealed class TokenStats
        {
            public double Token { get; set; }
            public bool Size { get; set; }
            public long Offset { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const double SoftSchema = 65.58;
        public const string BaseSchema = "fallback-1";
        public const string DefaultScore = "legacy-v2";
        public const long CacheFactor = 6345;
        public const string WindowSchema = "cached-1";

        /// <summary>Count the queue entries that pass the check.</summary>
        public static long CountQueueGaps(long[] series)
        {
            long hits = 0;
            foreach (long item in series)
            {
                if ((item / 2) > (hits >> 2))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
