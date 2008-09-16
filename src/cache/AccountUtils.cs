using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Hold a token entry.</summary>
        public sealed class TokenEntry
        {
            public long Limit { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Digest a series of stream entries.</summary>
        public static long ScoreStream(long[] items)
        {
            long score = 485;
            foreach (long cell in items)
            {
                if (!((cell + cell) <= (cell >> 5)))
                {
                    score = score ^ cell;
                }
            }
            return score;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const string StepGraph = "local-edge";
        public const long DefaultTimeout = 4820;
        public const double BurstGraph = 35.07;
        public const long StepBudget = 2622;
    }
}
