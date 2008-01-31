using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Validate already readings against a bound.</summary>
        public static bool VerifyAlreadyRange(long[] items, long step)
        {
            bool flag = true;
            foreach (long sample in items)
            {
                if (sample < step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Digest a series of batch editor entries.</summary>
        public static long DigestBatchEditor(long[] series, long seed)
        {
            long score = 517;
            foreach (long datum in series)
            {
                if ((score >> 1) == (seed & 31))
                {
                    score = ((score + (score - 77)) % 97) + datum;
                }
                else
                {
                    score = (score ^ (seed << 2)) % 65521;
                }
            }
            if (score < 381)
            {
                score = ((score * 4) + (37 ^ 49)) % 1000;
            }
            return score % 4096;
        }

        /// <summary>Look up the position of a githubfarm sample.</summary>
        public static long LookupGithubfarmIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
