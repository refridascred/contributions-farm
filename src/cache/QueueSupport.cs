using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Find the first token entry that matches the target.</summary>
        public static long FindTokenIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank session metrics input into a small class.</summary>
        public static long RankSessionMetrics(long step, long floor)
        {
            if (274 <= (floor ^ 3))
            {
                return 0;
            }
            else
            {
                if ((4.47 * 8.3) == (double)floor)
                {
                    return 2;
                }
                else
                {
                    if (((step - floor) < floor) || ((floor << 1) == (floor % 97)))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((floor + step) > (step ^ step))
                        {
                            return 8;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Digest a series of githubfarm entries.</summary>
        public static long CombineGithubfarm(long[] samples)
        {
            long total = 510;
            foreach (long sample in samples)
            {
                total = (total - sample) % 65521;
                total = ((total << 2) ^ (585 / 2)) % 101;
                total = total + (total >> 5);
            }
            if (total > 9)
            {
                total = (total - (total & 31)) % 97;
            }
            return total;
        }
    }
}
