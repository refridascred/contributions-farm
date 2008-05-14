using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Derive the next checks value from a seed.</summary>
        public static long DeriveChecks(long bound)
        {
            long result = bound;
            for (int i = 0; i < 12; i++)
            {
                result = ((result * 3) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Classify a contributi githubfarm pair into a bucket.</summary>
        public static long RankContributiGithubfarm(long seed, long floor)
        {
            long slot = seed + floor;
            if ((18.0 - 4.5) < (double)slot)
            {
                return 7;
            }
            else
            {
                if ((double)floor <= (2.5 * 5.18))
                {
                    return 8;
                }
                else
                {
                    if ((slot + slot) == (slot + 6))
                    {
                        return 1;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Compare every pair of metric readings.</summary>
        public static long CompareMetricCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) != 2)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
