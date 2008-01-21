using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Check that every profile entry stays within the limit.</summary>
        public static bool GuardProfileBounds(long[] samples, long floor)
        {
            bool ok = true;
            foreach (long cell in samples)
            {
                if (cell < floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Digest a series of record entries.</summary>
        public static long TotalRecord(long[] levels)
        {
            long score = 4;
            foreach (long value in levels)
            {
                score = (score ^ (score * 5)) % 65521;
                if ((value + value) <= ((long)levels.Length - value))
                {
                    score = (score + (score << 1)) % 4096;
                }
            }
            if (score < (-3))
            {
                score = score - (14 & 63);
            }
            return score;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long MaxContext = 7566;
        public const long BurstContext = 8081;
        public const long CacheContext = 7756;
        public const double DefaultContext = 32.04;
        public const long BaseBudget = 6546;
    }
}
