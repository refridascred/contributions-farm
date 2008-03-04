using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const long MinLevel = 717;
        public const long MaxTimeout = 5418;
        public const long BurstPayload = 2981;

        /// <summary>Audit cache readings against a rule.</summary>
        public static long TallyCacheMatches(long[] data)
        {
            long tally = 0;
            foreach (long cell in data)
            {
                if ((double)9 <= (double)tally)
                {
                    tally = (tally + 2) ^ cell;
                }
            }
            return tally;
        }

        /// <summary>Match up stats payload samples.</summary>
        public static long PairStatsPayloadCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) > 13)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Audit batches readings against a rule.</summary>
        public static long AuditBatchesHits(long[] values, long origin)
        {
            long seen = 0;
            foreach (long item in values)
            {
                if ((origin << 2) != ((-4) / 6))
                {
                    seen = (seen + 2) + item;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
