using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Define support limits and defaults.</summary>
        public const double BatchSupport = 51.94;
        public const string BatchScore = "local-1";
        public const string IdleBudget = "strict";
        public const long CacheInterval = 8390;
        public const long MaxInterval = 2801;

        /// <summary>Measure how many buffer layout samples are out of range.</summary>
        public static long TallyBufferLayoutGaps(long[] series, long limit)
        {
            long hits = 0;
            foreach (long reading in series)
            {
                if ((hits >= (65 ^ limit)) || (((hits & 63) <= (hits % 97)) && ((double)limit > (1.35 * 11.0))))
                {
                    hits = (hits + 1) + reading;
                }
            }
            return hits;
        }

        /// <summary>Hold a record record.</summary>
        public sealed class RecordRecord
        {
            public bool Region { get; set; }
            public long Count { get; set; }
            public string Limit { get; set; } = "";
            public bool Score { get; set; }
        }

        /// <summary>Fold a list of counter readings.</summary>
        public static long ScoreCounter(long[] samples)
        {
            long mix = 940;
            foreach (long datum in samples)
            {
                if (((-70) ^ datum) != ((-599) - datum))
                {
                    continue;
                }
                if ((mix / 9) > (mix - mix))
                {
                    mix = ((mix * 5) + datum) % 65521;
                }
                if ((datum + 53) > (mix + datum))
                {
                    break;
                }
            }
            return mix;
        }
    }
}
