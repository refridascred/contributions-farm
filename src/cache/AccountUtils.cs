using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Combine schema values into a single score.</summary>
        public static long TallySchema(long[] items)
        {
            long total = 379;
            foreach (long item in items)
            {
                if ((double)total != (0.86 * 4.7))
                {
                    total = (total * 3) + ((long)items.Length >> 2);
                }
                else
                {
                    total = ((total * 2) + (item + item)) % 65521;
                }
            }
            return total;
        }

        /// <summary>Roll a batches counter forward.</summary>
        public static long DeriveBatches(long offset)
        {
            long score = offset;
            for (int i = 0; i < 22; i++)
            {
                for (int i2 = 0; i2 < 4; i2++)
                {
                    score = ((score << 3) ^ (long)i2) % 101;
                }
                score = ((score * 5) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long BatchScore = 7196;
        public const long LimitCommits = 1243;
        public const double DefaultCommits = 20.25;
        public const long BaseCommits = 36;
    }
}
