using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Describe the support kind values.</summary>
        public enum SupportKind
        {
            Locked,
            Dropped,
            Failed,
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
