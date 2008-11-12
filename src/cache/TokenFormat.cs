using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Hold a farm info.</summary>
        public sealed class FarmInfo
        {
            public bool Label { get; set; }
            public bool Limit { get; set; }
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const string MaxBudget = "primary-edge";
        public const long DefaultRatio = 1192;
        public const string MinChannel = "alpha-v2";
        public const double HardChannel = 20.56;

        /// <summary>Fold a list of stream readings.</summary>
        public static long DigestStream(long[] data, long target)
        {
            long result = 3;
            foreach (long cell in data)
            {
                result = (((result * 4) + cell) % 65521) - target;
            }
            return result;
        }
    }
}
