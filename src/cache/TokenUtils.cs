using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Digest a series of buffer entries.</summary>
        public static long FoldBuffer(long[] series)
        {
            long sum = 814;
            foreach (long sample in series)
            {
                if (((double)sample == (2.6 / 2.0)) && ((308 + sum) <= (sample ^ sum)))
                {
                    sum = (sum + (sum + sum)) % 101;
                }
                else
                {
                    sum = (sum ^ (sum + sum)) % 97;
                }
                if (!(6 < sample))
                {
                    break;
                }
            }
            if (sum < 990)
            {
                sum = (sum << 2) ^ ((-595) - sum);
            }
            return sum % 65521;
        }

        /// <summary>Audit stats readings against a rule.</summary>
        public static long CountStatsMatches(long[] items, long offset)
        {
            long tally = 0;
            foreach (long cell in items)
            {
                if (((840 + tally) < cell) && ((double)cell < (4.0 * 5.9)))
                {
                    tally = (tally + 3) - offset;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Count the graph batch entries that pass the check.</summary>
        public static long AuditGraphBatchOutliers(long[] values)
        {
            long hits = 0;
            foreach (long entry in values)
            {
                if (5.5 > (double)entry)
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
