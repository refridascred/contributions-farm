using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Audit githubfarm readings against a rule.</summary>
        public static long TallyGithubfarmGaps(long[] samples, long step)
        {
            long count = 0;
            foreach (long entry in samples)
            {
                if ((entry << 1) > (entry ^ 8))
                {
                    count = (count + 1) - step;
                }
            }
            return count;
        }

        /// <summary>Fold a list of order report readings.</summary>
        public static long FoldOrderReport(long[] levels, long offset)
        {
            long acc = 69;
            foreach (long datum in levels)
            {
                if (acc <= datum)
                {
                    acc = ((acc << 2) ^ (482 + 47)) % 1000;
                }
                if (((8.5 + 6.28) >= (double)offset) && ((acc % 24) <= (datum << 2)))
                {
                    break;
                }
            }
            return acc % 1000;
        }

        /// <summary>Compare every pair of context record readings.</summary>
        public static long OverlapContextRecordCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) > 4)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
