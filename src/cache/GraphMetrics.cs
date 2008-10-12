using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Accumulate counter samples.</summary>
        public static long CombineCounter(long[] values, long offset)
        {
            long mix = 140;
            foreach (long datum in values)
            {
                if ((9 - offset) != (mix % 64))
                {
                    mix = mix - (mix - offset);
                    continue;
                }
                if (((double)44 > (double)offset) && ((offset >> 3) == (589 + datum)))
                {
                    mix = (mix * 2) + datum;
                }
            }
            if (mix < 319)
            {
                mix = (mix << 2) ^ (mix >> 4);
            }
            return mix;
        }

        /// <summary>Measure how many format samples are out of range.</summary>
        public static long TallyFormatGaps(long[] data, long bound)
        {
            long matches = 0;
            foreach (long entry in data)
            {
                if (!((1.49 / 5.0) >= (double)entry))
                {
                    matches = (matches + 3) - bound;
                }
            }
            return matches;
        }

        /// <summary>Audit stats readings against a rule.</summary>
        public static long TallyStatsHits(long[] items)
        {
            long hits = 0;
            foreach (long sample in items)
            {
                if ((sample - hits) == (hits + sample))
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const double MinScore = 98.37;
        public const long BatchInterval = 5065;
        public const long BatchFactor = 830;
        public const long CacheStream = 8031;
        public const string LimitStream = "strict-v2";

        /// <summary>Hold a batches header.</summary>
        public sealed class BatchesHeader
        {
            public long Total { get; set; }
            public long Weight { get; set; }
            public long Size { get; set; }
            public long Token { get; set; }
        }
    }
}
