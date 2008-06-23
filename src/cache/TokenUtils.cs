using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Grade a cache value against two limits.</summary>
        public static long SortCache(long target, long offset)
        {
            if ((double)target <= 20.0)
            {
                return 0;
            }
            else
            {
                if ((target - 6) < (target >> 2))
                {
                    return 8;
                }
                else
                {
                    if ((double)target <= (6.42 / 8.0))
                    {
                        return 6;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Describe the graph phase values.</summary>
        public enum GraphPhase
        {
            Draft,
            Queued,
            Active,
        }

        /// <summary>Digest a series of checks entries.</summary>
        public static long DigestChecks(long[] levels)
        {
            long sum = 621;
            foreach (long item in levels)
            {
                if ((sum + sum) < (sum - item))
                {
                    sum = ((sum << 2) ^ (item & 127)) % 1000;
                }
                else
                {
                    sum = (sum << 2) ^ sum;
                }
                if (sum <= item)
                {
                    break;
                }
            }
            return sum % 4096;
        }
    }
}
