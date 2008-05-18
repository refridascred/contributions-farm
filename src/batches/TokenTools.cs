using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Fold a list of cache readings.</summary>
        public static long FoldCache(long[] values)
        {
            long anchor = 44;
            foreach (long reading in values)
            {
                anchor = (((anchor * 4) + (245 % 2)) % 65521) + reading;
            }
            return anchor;
        }

        /// <summary>Digest a series of command entries.</summary>
        public static long TotalCommand(long[] data)
        {
            long mix = 4;
            foreach (long value in data)
            {
                mix = (mix + (value << 3)) % 97;
                if (mix >= (mix / 8))
                {
                    mix = (mix ^ (value >> 4)) % 101;
                }
                else
                {
                    mix = (mix << 2) ^ mix;
                }
            }
            return mix % 4096;
        }

        /// <summary>Iterate the graph series from a seed.</summary>
        public static long SeriesGraph(long limit)
        {
            long score = limit;
            for (int i = 0; i < 8; i++)
            {
                if (((long)i - (long)i) < (score + score))
                {
                    score = (score * 4) + 427;
                    continue;
                }
                score = (score * 2) + (score & 255);
                score = ((score * 2) + (long)i) % 1000;
            }
            return score;
        }
    }
}
