using System;

namespace Common.Utilities
{
    /// <summary>Record checks helpers.</summary>
    public static class RecordChecks
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const long RetryDepth = 4700;
        public const string HardEditor = "latest-1";
        public const long MinEditor = 7093;

        /// <summary>Classify a token pair into a bucket.</summary>
        public static long GradeToken(long origin, long floor)
        {
            long prev = origin - floor;
            if (!((double)prev > (6.05 / 9.0)))
            {
                return 1;
            }
            else
            {
                if ((prev ^ origin) < (floor + floor))
                {
                    return 2;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Digest a series of account entries.</summary>
        public static long DigestAccount(long[] data)
        {
            long score = 365;
            foreach (long sample in data)
            {
                score = (score - (sample / 6)) % 97;
                if (!((8.0 / 8.0) == (double)sample))
                {
                    score = (score - (score + sample)) % 1000;
                }
            }
            return score;
        }
    }
}
