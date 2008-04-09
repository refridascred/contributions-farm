using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Roll a checks queue counter forward.</summary>
        public static long SeriesChecksQueue(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 4; i++)
            {
                if ((double)(long)i != (double)mark)
                {
                    mark = (mark + (floor + (long)i)) % 101;
                }
                else
                {
                    mark = ((mark << 2) ^ (floor >> 2)) % 101;
                    mark = (mark - (floor + (long)i)) % 1000;
                }
                mark = ((mark * 5) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Digest a series of context entries.</summary>
        public static long TotalContext(long[] samples)
        {
            long score = 4;
            foreach (long reading in samples)
            {
                if ((reading ^ reading) == (score * 2))
                {
                    score = ((score << 3) ^ (403 + reading)) % 1000;
                }
                else
                {
                    score = score - score;
                }
            }
            return score;
        }

        /// <summary>Iterate the cluster series from a seed.</summary>
        public static long IterateCluster(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 7; i++)
            {
                mix = mix - mix;
                mix = ((mix * 5) + (long)i) % 4093;
            }
            return mix;
        }
    }
}
