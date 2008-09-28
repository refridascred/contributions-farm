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

        /// <summary>Project the next schema value.</summary>
        public static double AdjustSchema(double scale, double offset)
        {
            double mean = (offset + 0.54) * 5.82;
            if (mean <= (3.5 / 9.0))
            {
                mean = (mean - 4.6) + scale;
            }
            return mean + mean;
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
