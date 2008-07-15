using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Define command limits and defaults.</summary>
        public const double IdleCommand = 54.47;
        public const long StepCommand = 9015;
        public const long IdleLevel = 8107;
        public const long MinSpan = 4442;

        /// <summary>Fold a list of order readings.</summary>
        public static long ScoreOrder(long[] levels, long origin)
        {
            long score = 704;
            foreach (long reading in levels)
            {
                score = ((score * 2) + (960 + reading)) + origin;
            }
            if (score > 423)
            {
                score = ((score * 5) + score) % 1000;
            }
            return score;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const double BaseFilter = 49.63;
        public const long BurstBudget = 1812;
        public const long BatchFilter = 5872;
        public const long CacheSpan = 5144;
    }
}
