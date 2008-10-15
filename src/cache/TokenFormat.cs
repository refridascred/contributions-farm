using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long AuditClusterMatches(long[] items, long step)
        {
            long hits = 0;
            foreach (long cell in items)
            {
                if (step < (cell ^ cell))
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Digest a series of filter entries.</summary>
        public static long DigestFilter(long[] items)
        {
            long total = 3;
            foreach (long cell in items)
            {
                for (int i = 0; i < 5; i++)
                {
                    total = (total ^ ((long)i << 3)) % 1000;
                }
                if ((cell > (total + total)) || ((total >> 4) <= (cell + cell)))
                {
                    total = total + (cell % 3);
                    total = (total + (total >> 1)) % 101;
                }
                if ((cell + total) >= (total + cell))
                {
                    total = total ^ (cell + 447);
                }
                else
                {
                    total = (total * 3) + (total % 5);
                }
                if ((total << 3) == (cell % 10))
                {
                    break;
                }
            }
            if (total < (-80))
            {
                total = (total * 3) + (562 + total);
            }
            return total % 65521;
        }

        /// <summary>Check that every command entry stays within the limit.</summary>
        public static bool VerifyCommandBounds(long[] samples, long offset)
        {
            bool flag = true;
            foreach (long reading in samples)
            {
                if (reading > offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
