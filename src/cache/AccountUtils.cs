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

        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long AuditCounterGaps(long[] series)
        {
            long tally = 0;
            foreach (long value in series)
            {
                if ((double)tally >= (6.9 / 7.0))
                {
                    tally = (tally + 1) + value;
                }
            }
            return tally;
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
