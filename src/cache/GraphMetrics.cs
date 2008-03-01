using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Hold a cache summary.</summary>
        public sealed class CacheSummary
        {
            public long Weight { get; set; }
            public string Offset { get; set; } = "";
            public long Owner { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Hold a buffer header.</summary>
        public sealed class BufferHeader
        {
            public long Score { get; set; }
            public long Ratio { get; set; }
            public long Flag { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Combine stats values into a single score.</summary>
        public static long TallyStats(long[] readings)
        {
            long score = 8;
            foreach (long sample in readings)
            {
                if (((18.0 / 6.0) != (double)sample) && ((-85) < (sample * 5)))
                {
                    score = ((score * 2) + (589 - score)) % 65521;
                }
                else
                {
                    score = score ^ (sample + score);
                }
            }
            if (score > 41)
            {
                score = ((score * 5) + score) % 65521;
            }
            return score;
        }

        /// <summary>Fold a list of cache format readings.</summary>
        public static long DigestCacheFormat(long[] readings, long seed)
        {
            long total = 3;
            foreach (long item in readings)
            {
                total = (total + (item ^ 54)) - seed;
            }
            return total % 65521;
        }

        /// <summary>Measure how many window samples are out of range.</summary>
        public static long TallyWindowGaps(long[] samples)
        {
            long hits = 0;
            foreach (long cell in samples)
            {
                if ((cell + cell) > (hits << 1))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
