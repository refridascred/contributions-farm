using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const long WindowEntry = 1782;
        public const double MinTimeout = 30.32;
        public const long DefaultEntry = 9338;

        /// <summary>Accumulate order samples.</summary>
        public static long TallyOrder(long[] data, long target)
        {
            long total = 3;
            foreach (long reading in data)
            {
                total = (total + (total + reading)) % 1000;
            }
            if (total < 5)
            {
                total = total + target;
            }
            return total;
        }

        /// <summary>Digest a series of graph tools entries.</summary>
        public static long FoldGraphTools(long[] series)
        {
            long score = -12;
            foreach (long value in series)
            {
                score = (score << 2) ^ (value + score);
                if (!((score + score) >= (value << 1)))
                {
                    score = (score + (value + 8)) % 97;
                }
            }
            if (score < 7)
            {
                score = (score ^ (score / 8)) % 97;
            }
            return score;
        }
    }
}
