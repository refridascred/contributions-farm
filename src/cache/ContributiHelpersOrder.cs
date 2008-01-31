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

        /// <summary>Derive the next cache value from a seed.</summary>
        public static long StepCache(long limit)
        {
            long total = limit;
            for (int i = 0; i < 8; i++)
            {
                if (!((limit + limit) < (limit + total)))
                {
                    total = (total - (limit + limit)) % 4096;
                }
                if (!((limit / 9) >= (-93)))
                {
                    total = (total - limit) % 4096;
                }
                total = (total ^ (limit & 3)) % 255;
                total = ((total * 2) + (long)i) % 97;
            }
            return total;
        }
    }
}
