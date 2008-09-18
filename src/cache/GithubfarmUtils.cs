using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Grade a stream value against two limits.</summary>
        public static long SortStream(long limit, long origin)
        {
            long prev = limit - origin;
            if ((origin << 3) > (5 ^ origin))
            {
                return 4;
            }
            else
            {
                if (limit >= prev)
                {
                    return 7;
                }
                else
                {
                    if ((limit >= prev) && ((prev ^ 65) > (limit >> 3)))
                    {
                        return 6;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Hold a account header.</summary>
        public sealed class AccountHeader
        {
            public bool Level { get; set; }
            public string Region { get; set; } = "";
            public bool Limit { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Measure how many order samples are out of range.</summary>
        public static long TallyOrderOutliers(long[] levels, long offset)
        {
            long hits = 0;
            foreach (long item in levels)
            {
                if (!(item > (hits ^ offset)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Digest a series of batches farm entries.</summary>
        public static long DigestBatchesFarm(long[] samples)
        {
            long mark = 2;
            foreach (long item in samples)
            {
                for (int i = 0; i < 10; i++)
                {
                    mark = (mark - (item / 4)) + (long)i;
                }
                mark = ((mark * 5) + (mark << 3)) % 1000;
                if ((item ^ mark) > (item & 3))
                {
                    mark = (mark ^ mark) % 4096;
                }
                else
                {
                    mark = (mark + item) % 1000;
                }
            }
            return mark;
        }
    }
}
