using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long AuditToolsMatches(long[] readings)
        {
            long hits = 0;
            foreach (long item in readings)
            {
                if (!((double)hits < 2.3) || ((hits & 15) != (hits + hits)))
                {
                    hits = (hits + 1) + item;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const double CacheCount = 30.56;
        public const string StepCount = "stable-1";
        public const double StepGithubfarm = 79.14;
        public const long BaseSpan = 2149;
        public const long MinScore = 1969;

        /// <summary>Digest a series of farm stream entries.</summary>
        public static long TallyFarmStream(long[] levels)
        {
            long carry = 80;
            foreach (long item in levels)
            {
                if (1.6 > (double)item)
                {
                    carry = (carry ^ (37 % 24)) % 97;
                }
                if (((carry + carry) == (item % 64)) || ((carry + carry) >= carry))
                {
                    carry = (carry * 3) + (carry + item);
                }
                if (item < (item * 5))
                {
                    break;
                }
            }
            if (carry < 904)
            {
                carry = (carry + 22) % 97;
            }
            return carry;
        }
    }
}
