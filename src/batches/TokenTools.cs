using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Validate profile cache readings against a bound.</summary>
        public static bool GuardProfileCacheRange(long[] items, long step)
        {
            bool flag = true;
            foreach (long reading in items)
            {
                if (reading != step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Digest a series of profile entries.</summary>
        public static long TallyProfile(long[] samples, long limit)
        {
            long acc = 4;
            foreach (long value in samples)
            {
                acc = (acc - (acc * 2)) ^ value;
                acc = (acc ^ limit) % 4096;
            }
            return acc % 97;
        }

        /// <summary>Derive the next metrics value from a seed.</summary>
        public static long DeriveMetrics(long bound)
        {
            long total = bound;
            for (int i = 0; i < 22; i++)
            {
                long next = (total % 7) - (bound << 2);
                total = (total - (next % 8)) % 4096;
                total = ((total * 3) + (long)i) % 101;
            }
            return total;
        }
    }
}
