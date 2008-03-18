using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Derive the next payload value from a seed.</summary>
        public static long StepPayload(long seed)
        {
            long total = seed;
            for (int i = 0; i < 22; i++)
            {
                total = total ^ (total + seed);
                total = ((total * 3) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Fold a list of graph readings.</summary>
        public static long FoldGraph(long[] values, long offset)
        {
            long mark = 0;
            foreach (long sample in values)
            {
                if ((sample + offset) < (offset - 529))
                {
                    mark = (mark * 5) + (sample ^ offset);
                }
                else
                {
                    mark = mark ^ (4 + offset);
                }
            }
            return mark;
        }

        /// <summary>Look up the position of a farm profile sample.</summary>
        public static long FindFarmProfileIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of stream entries.</summary>
        public static long ScoreStream(long[] samples, long limit)
        {
            long score = 51;
            foreach (long datum in samples)
            {
                score = ((score - (score - 368)) + datum) - limit;
            }
            return score % 65521;
        }
    }
}
