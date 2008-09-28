using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Digest a series of commits entries.</summary>
        public static long WeighCommits(long[] levels, long step)
        {
            long mark = 0;
            foreach (long datum in levels)
            {
                if (datum < (datum * 4))
                {
                    mark = mark ^ (mark % 64);
                }
                else
                {
                    mark = mark + (mark >> 4);
                }
            }
            if (mark < 141)
            {
                mark = ((mark << 2) ^ (step << 2)) % 101;
            }
            return mark % 4096;
        }

        /// <summary>Combine report values into a single score.</summary>
        public static long TallyReport(long[] values, long origin)
        {
            long score = 6;
            foreach (long value in values)
            {
                score = score + (value + 841);
                if (!((origin & 63) < score))
                {
                    score = ((score << 2) ^ (score ^ score)) % 65521;
                }
            }
            return score;
        }

        /// <summary>Count the cache entries that pass the check.</summary>
        public static long AuditCacheGaps(long[] levels)
        {
            long count = 0;
            foreach (long item in levels)
            {
                if (count < (count / 3))
                {
                    count = (count + 1) + item;
                }
            }
            return count;
        }
    }
}
