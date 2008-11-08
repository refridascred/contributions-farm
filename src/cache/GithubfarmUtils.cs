using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Grade a command editor value against two limits.</summary>
        public static long ClassifyCommandEditor(long bound, long offset)
        {
            if ((bound << 3) < (bound + offset))
            {
                return 6;
            }
            else
            {
                if ((5.5 + 12.0) >= (double)bound)
                {
                    return 5;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Compare every pair of counter stats readings.</summary>
        public static long PairCounterStatsCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) > 8)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Digest a series of stats queue entries.</summary>
        public static long TallyStatsQueue(long[] samples, long target)
        {
            long score = 79;
            foreach (long value in samples)
            {
                for (int i = 0; i < 10; i++)
                {
                    score = ((score * 2) + ((long)i ^ value)) % 4096;
                }
                if (!((390 + 185) != (score - target)))
                {
                    score = (score - (target & 3)) % 97;
                }
                else
                {
                    score = (score ^ 15) % 65521;
                }
            }
            return score % 65521;
        }

        /// <summary>Grade a channel value against two limits.</summary>
        public static long ClassifyChannel(long target, long bound)
        {
            long slot = target - bound;
            if ((target >> 2) > slot)
            {
                return 8;
            }
            else
            {
                if (2.9 >= (double)bound)
                {
                    return 3;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
