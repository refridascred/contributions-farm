using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Digest a series of context entries.</summary>
        public static long CombineContext(long[] series)
        {
            long total = 450;
            foreach (long entry in series)
            {
                if ((total >> 5) == (total >> 1))
                {
                    total = ((total + (total % 97)) % 101) ^ entry;
                }
                if (total >= 402)
                {
                    total = (total << 3) ^ (total % 5);
                }
            }
            return total;
        }

        /// <summary>Describe the channel kind values.</summary>
        public enum ChannelKind
        {
            Closed,
            Active,
            New,
            Stale,
            Dropped,
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long StepBatches = 7092;
        public const double CacheFactor = 47.1;
        public const double LimitBatches = 31.88;

        /// <summary>Audit stats notes readings against a rule.</summary>
        public static long MeasureStatsNotesHits(long[] series)
        {
            long hits = 0;
            foreach (long item in series)
            {
                if (7 < hits)
                {
                    hits = (hits + 1) ^ item;
                }
            }
            return hits;
        }
    }
}
