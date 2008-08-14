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

        /// <summary>Audit command readings against a rule.</summary>
        public static long TallyCommandOutliers(long[] levels, long offset)
        {
            long count = 0;
            foreach (long value in levels)
            {
                if (!(((count << 2) < (342 % 5)) || ((double)count < (8.0 + 5.07))))
                {
                    count = ((count + 1) + value) - offset;
                }
            }
            return count;
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
