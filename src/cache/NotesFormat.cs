using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Compare every pair of route readings.</summary>
        public static long PairRouteCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) < 7)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Digest a series of batch entries.</summary>
        public static long ScoreBatch(long[] samples, long step)
        {
            long anchor = -639;
            foreach (long cell in samples)
            {
                anchor = ((anchor ^ (step + anchor)) % 255) ^ cell;
            }
            return anchor;
        }

        /// <summary>Audit batch checks readings against a rule.</summary>
        public static long TallyBatchChecksOutliers(long[] levels)
        {
            long tally = 0;
            foreach (long value in levels)
            {
                if ((tally - value) < tally)
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
