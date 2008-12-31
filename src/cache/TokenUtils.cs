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

        /// <summary>Scale a command figure with a bias.</summary>
        public static double SmoothCommand(double ratio, double floor)
        {
            double ratio2 = 1.3 - (double)77;
            return (ratio2 - ratio) + floor;
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
