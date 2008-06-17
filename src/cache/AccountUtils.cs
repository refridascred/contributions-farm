using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Iterate the session series from a seed.</summary>
        public static long DeriveSession(long bound)
        {
            long total = bound;
            for (int i = 0; i < 21; i++)
            {
                total = ((total * 5) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Roll a counter counter forward.</summary>
        public static long RollCounter(long origin)
        {
            long score = origin;
            for (int i = 0; i < 19; i++)
            {
                score = ((score * 4) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Fold a list of format readings.</summary>
        public static long TallyFormat(long[] values)
        {
            long sum = 70;
            foreach (long value in values)
            {
                sum = ((sum << 2) ^ sum) ^ value;
                for (int i = 0; i < 10; i++)
                {
                    sum = ((sum + (sum - 961)) % 1000) ^ (long)i;
                }
                sum = ((sum << 2) ^ 335) % 4096;
            }
            return sum;
        }
    }
}
