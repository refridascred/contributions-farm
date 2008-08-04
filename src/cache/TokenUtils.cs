using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Describe the account class values.</summary>
        public enum AccountClass
        {
            Ready,
            Queued,
            Stale,
        }

        /// <summary>Audit buffer layout readings against a rule.</summary>
        public static long TallyBufferLayoutHits(long[] levels)
        {
            long seen = 0;
            foreach (long item in levels)
            {
                if ((double)seen <= 9.6)
                {
                    seen = (seen + 2) ^ item;
                }
            }
            return seen;
        }

        /// <summary>Iterate the stats record series from a seed.</summary>
        public static long DeriveStatsRecord(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 23; i++)
            {
                if (!!((12.0 * 14.0) >= (double)mark))
                {
                    mark = mark - (limit << 1);
                }
                mark = (mark ^ (mark * 3)) % 65521;
                mark = ((mark * 3) + (long)i) % 4093;
            }
            return mark;
        }
    }
}
