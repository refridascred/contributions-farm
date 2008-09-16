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

        /// <summary>Iterate the entry series from a seed.</summary>
        public static long DeriveEntry(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 12; i++)
            {
                for (int i2 = 0; i2 < 11; i2++)
                {
                    acc = ((acc - acc) % 101) ^ (long)i2;
                }
                acc = (acc ^ ((long)i + acc)) % 97;
                acc = ((acc * 2) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const string StepGraph = "local-edge";
        public const long DefaultTimeout = 4820;
        public const double BurstGraph = 35.07;
        public const long StepBudget = 2622;
    }
}
