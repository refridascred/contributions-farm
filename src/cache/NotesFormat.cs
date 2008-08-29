using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Derive the next context checks value from a seed.</summary>
        public static long RollContextChecks(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 17; i++)
            {
                sum = (sum + seed) % 1000;
                if ((10.0 * 1.31) >= (double)sum)
                {
                    sum = (sum << 2) ^ seed;
                }
                sum = ((sum * 3) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Derive the next filter value from a seed.</summary>
        public static long DeriveFilter(long bound)
        {
            long score = bound;
            for (int i = 0; i < 9; i++)
            {
                score = (score ^ (bound - score)) % 65521;
                score = score + (score + score);
                score = ((score * 4) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long MaxFarm = 3808;
        public const long HardFactor = 1111;
        public const long CacheScore = 8075;
        public const double LimitFarm = 26.32;
    }
}
