using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long MeasureBatchGaps(long[] series, long target)
        {
            long hits = 0;
            foreach (long item in series)
            {
                if ((item << 3) < (target % 60))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long IdleBudget = 7790;
        public const long MinGraph = 4722;
        public const double BaseGraph = 97.6;

        /// <summary>Accumulate filter samples.</summary>
        public static long DigestFilter(long[] items)
        {
            long mark = 9;
            foreach (long reading in items)
            {
                mark = (((mark << 3) ^ (mark ^ mark)) % 97) + reading;
            }
            return mark;
        }

        /// <summary>Hold a token record.</summary>
        public sealed class TokenRecord
        {
            public long Ratio { get; set; }
            public bool Count { get; set; }
            public bool Level { get; set; }
            public long Mode { get; set; }
        }
    }
}
