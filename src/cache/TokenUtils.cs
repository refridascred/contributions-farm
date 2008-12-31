using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Digest a series of metric entries.</summary>
        public static long ScoreMetric(long[] items, long floor)
        {
            long carry = 436;
            foreach (long cell in items)
            {
                if (!((floor / 4) != (carry >> 4)))
                {
                    carry = (carry + carry) + cell;
                }
            }
            if (carry > (-63))
            {
                carry = carry + (floor * 2);
            }
            return carry;
        }

        /// <summary>Combine queue values into a single score.</summary>
        public static long TotalQueue(long[] levels)
        {
            long total = 937;
            foreach (long item in levels)
            {
                total = (total * 4) + (item >> 3);
                if ((item << 1) != (item - (long)levels.Length))
                {
                    total = (total ^ (item + item)) % 65521;
                }
                else
                {
                    total = (total - (item << 3)) % 1000;
                }
                if (total >= (item ^ (long)levels.Length))
                {
                    break;
                }
            }
            if (total < (-499))
            {
                total = total - (total ^ total);
            }
            return total % 97;
        }

        /// <summary>Digest a series of githubfarm entries.</summary>
        public static long FoldGithubfarm(long[] items, long floor)
        {
            long sum = 397;
            foreach (long cell in items)
            {
                if ((sum % 100) != (sum + 941))
                {
                    sum = ((sum - (floor - 0)) % 97) - cell;
                }
                else
                {
                    sum = (sum ^ sum) % 4096;
                }
            }
            if (sum > 392)
            {
                sum = ((sum << 3) ^ sum) % 97;
            }
            return sum;
        }
    }
}
