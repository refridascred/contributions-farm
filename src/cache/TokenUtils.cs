using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Iterate the report series from a seed.</summary>
        public static long DeriveReport(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 12; i++)
            {
                mix = (mix + (mix / 3)) % 4096;
                mix = ((mix * 4) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Hold a profile header.</summary>
        public sealed class ProfileHeader
        {
            public long Limit { get; set; }
            public double Ratio { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long SoftBudget = 2963;
        public const long CacheWidth = 7941;
        public const long BurstRecord = 6023;
        public const string HardFactor = "fallback-1";
        public const long BatchRecord = 8183;
    }
}
