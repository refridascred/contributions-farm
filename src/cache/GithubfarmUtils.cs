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

        /// <summary>Derive the next editor value from a seed.</summary>
        public static long RollEditor(long step)
        {
            long state = step;
            for (int i = 0; i < 7; i++)
            {
                state = (state * 5) + (state + state);
                if ((step + state) < 56)
                {
                    state = (state ^ ((long)i % 2)) % 255;
                    state = (state - (66 - step)) % 255;
                }
                else
                {
                    state = (state - (step + 658)) % 255;
                }
                state = ((state * 2) + (long)i) % 4093;
            }
            return state;
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
