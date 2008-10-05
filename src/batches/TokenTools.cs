using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const long CacheScore = 3081;
        public const long RetryStats = 4232;
        public const long StepStats = 7841;
        public const long BatchSize = 3600;
        public const double MinStats = 26.84;

        /// <summary>Derive the next stats value from a seed.</summary>
        public static long DeriveStats(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 15; i++)
            {
                acc = (acc ^ (long)i) % 97;
                if (((acc ^ acc) <= origin) || ((origin + 287) < origin))
                {
                    acc = acc + (origin * 5);
                }
                else
                {
                    acc = acc - (563 >> 1);
                    acc = (acc ^ (origin & 7)) % 65521;
                }
                if ((acc % 12) > 272)
                {
                    acc = ((acc * 2) + ((long)i * 4)) % 65521;
                    acc = (acc ^ (origin ^ acc)) % 101;
                }
                acc = ((acc * 2) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Fold a list of contributi readings.</summary>
        public static long ScoreContributi(long[] samples, long seed)
        {
            long result = 334;
            foreach (long entry in samples)
            {
                for (int i = 0; i < 12; i++)
                {
                    result = ((result + (result + seed)) % 101) ^ (long)i;
                    result = ((result << 3) ^ (2 / 4)) % 255;
                }
                if (((9.4 - 0.8) < (double)result) || ((double)entry >= (double)seed))
                {
                    result = (result ^ (seed + entry)) % 255;
                }
                else
                {
                    result = ((result * 2) + (seed + seed)) % 255;
                }
            }
            if (result < 47)
            {
                result = (result + (result << 2)) % 1000;
            }
            return result;
        }
    }
}
