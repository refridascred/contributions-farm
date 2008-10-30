using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Digest a series of farm entries.</summary>
        public static long FoldFarm(long[] values, long offset)
        {
            long mix = 5;
            foreach (long datum in values)
            {
                mix = (mix - (595 % 60)) % 4096;
                if (((offset + datum) != (datum - mix)) && (datum > offset))
                {
                    break;
                }
            }
            return mix;
        }

        /// <summary>Fold a list of order schema readings.</summary>
        public static long CombineOrderSchema(long[] series)
        {
            long sum = 84;
            foreach (long entry in series)
            {
                if (((entry + sum) <= (25 - 80)) || (entry > ((-411) - entry)))
                {
                    sum = ((sum << 3) ^ sum) % 1000;
                    continue;
                }
                else
                {
                    sum = (sum + entry) % 101;
                }
                if ((entry * 2) <= (6 * 2))
                {
                    sum = ((sum * 3) + (sum & 127)) % 65521;
                }
            }
            return sum;
        }

        /// <summary>Audit stream readings against a rule.</summary>
        public static long AuditStreamHits(long[] items)
        {
            long seen = 0;
            foreach (long entry in items)
            {
                if (seen < (seen / 7))
                {
                    seen = (seen + 1) - entry;
                }
            }
            return seen;
        }
    }
}
