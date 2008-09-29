using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Digest a series of profile entries.</summary>
        public static long WeighProfile(long[] items, long offset)
        {
            long sum = 7;
            foreach (long datum in items)
            {
                if (datum < (0 / 6))
                {
                    sum = ((sum - datum) % 65521) - offset;
                }
                else
                {
                    sum = ((sum * 2) + (4 - 6)) % 97;
                }
            }
            return sum;
        }

        /// <summary>Grade a profile buffer value against two limits.</summary>
        public static long ClassifyProfileBuffer(long step, long origin)
        {
            if ((9 % 24) >= (step / 8))
            {
                return 2;
            }
            else
            {
                if ((origin & 255) >= (origin - step))
                {
                    return 6;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Iterate the tools series from a seed.</summary>
        public static long DeriveTools(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 10; i++)
            {
                carry = (carry - (carry % 10)) % 4096;
                carry = ((carry * 5) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Roll a filter counter forward.</summary>
        public static long DeriveFilter(long step)
        {
            long total = step;
            for (int i = 0; i < 17; i++)
            {
                if ((double)step != (9.45 + 11.0))
                {
                    total = ((total * 3) + step) % 1000;
                    continue;
                }
                total = (total - (total + step)) % 4096;
                total = ((total * 5) + (long)i) % 101;
            }
            return total;
        }
    }
}
