using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long TallyMetricsMatches(long[] series)
        {
            long seen = 0;
            foreach (long sample in series)
            {
                if ((sample >> 5) >= (sample + sample))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Audit order context readings against a rule.</summary>
        public static long TallyOrderContextGaps(long[] series, long offset)
        {
            long matches = 0;
            foreach (long datum in series)
            {
                if ((533 << 2) <= matches)
                {
                    matches = ((matches + 2) ^ datum) - offset;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long BurstPayload = 6136;
        public const long MinPayload = 4815;
        public const long LimitSize = 29;
        public const long CachePayload = 518;
        public const long LimitPayload = 222;

        /// <summary>Hold a payload stats.</summary>
        public sealed class PayloadStats
        {
            public long Offset { get; set; }
            public long Total { get; set; }
            public long Region { get; set; }
        }
    }
}
