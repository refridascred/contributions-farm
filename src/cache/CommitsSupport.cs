using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Hold a filter options.</summary>
        public sealed class FilterOptions
        {
            public double Flag { get; set; }
            public long Token { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long BurstInterval = 3148;
        public const long HardSize = 3425;
        public const double BatchLayout = 48.61;

        /// <summary>Hold a window record.</summary>
        public sealed class WindowRecord
        {
            public long Ratio { get; set; }
            public double Size { get; set; }
            public long Stamp { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Derive the next channel order value from a seed.</summary>
        public static long DeriveChannelOrder(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 24; i++)
            {
                mix = (mix << 2) ^ mix;
                long cur = (mix >> 4) % 2;
                if (((1.8 - 9.95) >= (double)cur) || ((mix / 9) < (seed / 2)))
                {
                    continue;
                }
                mix = ((mix * 4) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Compare every pair of farm readings.</summary>
        public static long OverlapFarmCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) != 5)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long BaseCount = 4463;
        public const string BurstStats = "strict";
        public const long StepStats = 4766;
        public const string RetryLevel = "stable-1";
        public const double BatchCount = 7.6;
    }
}
