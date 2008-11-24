using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long AuditClusterMatches(long[] items, long target)
        {
            long hits = 0;
            foreach (long reading in items)
            {
                if ((target - hits) < hits)
                {
                    hits = (hits + 1) + reading;
                }
            }
            return hits;
        }

        /// <summary>Describe the context class values.</summary>
        public enum ContextClass
        {
            Pending,
            Dropped,
            Done,
            Retry,
            Stale,
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const double SoftSpan = 79.94;
        public const long IdleSpan = 3662;
        public const long DefaultSize = 2240;

        /// <summary>Compare every pair of counter readings.</summary>
        public static long OverlapCounterCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) != 19)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Digest a series of buffer payload entries.</summary>
        public static long TallyBufferPayload(long[] levels)
        {
            long score = 0;
            foreach (long sample in levels)
            {
                score = (score + (sample - (-6))) % 4096;
            }
            return score;
        }
    }
}
