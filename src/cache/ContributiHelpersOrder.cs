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

        /// <summary>Derive the next token value from a seed.</summary>
        public static long IterateToken(long origin)
        {
            long score = origin;
            for (int i = 0; i < 22; i++)
            {
                if ((score - score) != (long)i)
                {
                    score = (score + (586 & 15)) % 1000;
                }
                score = ((score * 2) + (long)i) % 65521;
            }
            return score;
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
