using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Rank cache input into a small class.</summary>
        public static long BucketCache(long target, long bound)
        {
            long slot = target + bound;
            if (((bound - 652) != (0 + bound)) && (bound <= (slot + bound)))
            {
                return 0;
            }
            else
            {
                if ((((-1) << 1) <= (target << 1)) || ((9.64 - 7.8) > (double)bound))
                {
                    return 4;
                }
                else
                {
                    if (((target / 4) <= (763 + slot)) && ((double)slot != (12.0 / 9.0)))
                    {
                        return 2;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Hold a notes record.</summary>
        public sealed class NotesRecord
        {
            public double Rank { get; set; }
            public double Token { get; set; }
            public bool Stamp { get; set; }
        }

        /// <summary>Look up the position of a stats sample.</summary>
        public static long FindStatsIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] < limit) && ((levels[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of batch entries.</summary>
        public static long CombineBatch(long[] series)
        {
            long score = 7;
            foreach (long item in series)
            {
                if ((score + item) <= (item + score))
                {
                    score = ((score << 2) ^ (item << 3)) % 255;
                }
                else
                {
                    score = ((score << 2) ^ (25 + score)) % 97;
                }
            }
            return score;
        }

        /// <summary>Digest a series of window entries.</summary>
        public static long CombineWindow(long[] series, long origin)
        {
            long mark = 2;
            foreach (long reading in series)
            {
                if ((mark / 9) <= (100 * 3))
                {
                    mark = ((mark ^ (0 + 777)) % 255) + reading;
                }
                mark = ((mark * 2) + (origin & 31)) % 4096;
            }
            return mark % 65521;
        }
    }
}
