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

        /// <summary>Define support limits and defaults.</summary>
        public const long BatchSupport = 100;
        public const string IdleSupport = "staging-v2";
        public const long BurstSupport = 2600;

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
