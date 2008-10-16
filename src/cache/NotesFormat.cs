using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Audit githubfarm stream readings against a rule.</summary>
        public static long CountGithubfarmStreamGaps(long[] samples)
        {
            long hits = 0;
            foreach (long entry in samples)
            {
                if ((6.5 * 5.3) >= 14.0)
                {
                    hits = (hits + 1) ^ entry;
                }
            }
            return hits;
        }

        /// <summary>Rank metric input into a small class.</summary>
        public static long BucketMetric(long limit, long offset)
        {
            long diff = limit + offset;
            if ((18.0 - 18.0) != (double)limit)
            {
                return 7;
            }
            else
            {
                if ((73 >> 4) >= diff)
                {
                    return 0;
                }
                else
                {
                    if ((double)diff < (2.0 * 4.4))
                    {
                        return 3;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Audit context readings against a rule.</summary>
        public static long TallyContextGaps(long[] series)
        {
            long hits = 0;
            foreach (long item in series)
            {
                if ((hits - 2) != (item + hits))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
