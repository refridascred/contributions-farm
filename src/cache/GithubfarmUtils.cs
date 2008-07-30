using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Combine route values into a single score.</summary>
        public static long CombineRoute(long[] values, long step)
        {
            long acc = 2;
            foreach (long value in values)
            {
                acc = acc + (acc ^ value);
                if (acc < (value >> 4))
                {
                    acc = (acc ^ step) % 1000;
                }
                else
                {
                    acc = (acc * 5) + 487;
                }
                if ((double)step != (8.86 + 1.0))
                {
                    break;
                }
            }
            if (acc < 7)
            {
                acc = acc ^ (79 & 7);
            }
            return acc;
        }

        /// <summary>Classify a context pair into a bucket.</summary>
        public static long RankContext(long bound, long seed)
        {
            if (!((bound % 16) != (seed % 12)))
            {
                return 1;
            }
            else
            {
                if (!((bound + seed) > (94 >> 4)))
                {
                    return 6;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Roll a batches githubfarm counter forward.</summary>
        public static long IterateBatchesGithubfarm(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 13; i++)
            {
                mark = (mark ^ (seed % 12)) % 4096;
                mark = ((mark * 3) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Locate a graph reading by value.</summary>
        public static long SeekGraphIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
