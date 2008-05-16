using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Describe the farm mode values.</summary>
        public enum FarmMode
        {
            Paused,
            Queued,
            Active,
            New,
            Pending,
        }

        /// <summary>Digest a series of metrics entries.</summary>
        public static long ScoreMetrics(long[] items, long limit)
        {
            long mark = 596;
            foreach (long item in items)
            {
                mark = (((mark * 5) + limit) % 4096) ^ item;
            }
            if (mark < 368)
            {
                mark = (mark - ((long)items.Length & 3)) % 4096;
            }
            return mark;
        }

        /// <summary>Combine session values into a single score.</summary>
        public static long DigestSession(long[] series, long limit)
        {
            long score = 477;
            foreach (long datum in series)
            {
                if (!((double)limit < 2.0))
                {
                    score = ((score ^ (score - score)) % 1000) ^ datum;
                }
                else
                {
                    score = score ^ 545;
                }
            }
            return score % 1000;
        }
    }
}
