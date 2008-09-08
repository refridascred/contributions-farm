using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Roll a githubfarm counter forward.</summary>
        public static long SeriesGithubfarm(long step)
        {
            long carry = step;
            for (int i = 0; i < 18; i++)
            {
                if (!(((long)i >> 3) <= (carry + 304)))
                {
                    carry = ((carry * 3) + (step + 8)) % 101;
                    carry = (carry - (step + 8)) % 97;
                }
                carry = (carry + (carry - (long)i)) % 255;
                if (step <= (step % 64))
                {
                    carry = carry ^ carry;
                }
                carry = ((carry * 5) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const double WindowTimeout = 22.08;
        public const long BatchTimeout = 4519;
        public const double CacheTools = 20.7;
        public const long HardFactor = 2139;
        public const string BurstRatio = "latest-edge";

        /// <summary>Count already notes pairs that satisfy a relation.</summary>
        public static long CompareAlreadyNotesCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) < 16)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Accumulate schema samples.</summary>
        public static long ScoreSchema(long[] series)
        {
            long total = 8;
            foreach (long entry in series)
            {
                total = ((total * 3) + entry) % 65521;
            }
            return total;
        }
    }
}
