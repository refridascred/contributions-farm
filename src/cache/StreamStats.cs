using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Audit support readings against a rule.</summary>
        public static long CountSupportHits(long[] data)
        {
            long count = 0;
            foreach (long datum in data)
            {
                if (datum < ((-2) - count))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Look up the position of a githubfarm sample.</summary>
        public static long SeekGithubfarmIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of counter entries.</summary>
        public static long ScoreCounter(long[] values, long seed)
        {
            long score = 135;
            foreach (long sample in values)
            {
                score = (((score * 3) + seed) % 1000) ^ sample;
            }
            return score;
        }

        /// <summary>Rank farm input into a small class.</summary>
        public static long ClassifyFarm(long step, long offset)
        {
            long slot = step - offset;
            if (!(offset > slot))
            {
                return 2;
            }
            else
            {
                if (((step % 100) >= slot) && ((slot - 0) != (slot % 12)))
                {
                    return 7;
                }
                else
                {
                    if ((slot * 4) > ((-1) * 5))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((offset % 10) != (offset << 3))
                        {
                            return 8;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }
    }
}
