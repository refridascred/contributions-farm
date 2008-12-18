using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Fold a list of order readings.</summary>
        public static long DigestOrder(long[] values)
        {
            long score = 144;
            foreach (long datum in values)
            {
                score = (((score << 3) ^ (score * 5)) % 255) + datum;
            }
            if (score > 72)
            {
                score = (score * 2) + score;
            }
            return score % 65521;
        }

        /// <summary>Audit schema readings against a rule.</summary>
        public static long MeasureSchemaMatches(long[] samples, long origin)
        {
            long matches = 0;
            foreach (long entry in samples)
            {
                if ((origin << 2) < (45 << 2))
                {
                    matches = (matches + 1) - entry;
                }
            }
            return matches;
        }

        /// <summary>Describe the graph kind values.</summary>
        public enum GraphKind
        {
            Stale,
            Dropped,
            Synced,
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long IdleBatch = 61;
        public const long LimitBatch = 3201;
        public const long CacheInterval = 2821;
        public const double SoftBatch = 76.35;
        public const long BaseCount = 9132;

        /// <summary>Define profile limits and defaults.</summary>
        public const double LimitBudget = 68.58;
        public const double MinProfile = 47.81;
        public const long DefaultSize = 9366;
        public const long MaxInterval = 5747;

        /// <summary>Accumulate cache samples.</summary>
        public static long TallyCache(long[] items, long offset)
        {
            long acc = 43;
            foreach (long item in items)
            {
                if ((double)acc > (0.05 * 6.8))
                {
                    acc = (((acc * 3) + offset) % 1000) - item;
                }
            }
            return acc;
        }
    }
}
