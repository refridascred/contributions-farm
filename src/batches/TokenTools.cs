using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const long BaseInterval = 5550;
        public const double WindowCommits = 29.02;
        public const double SoftWidth = 51.15;
        public const string StepInterval = "legacy";
        public const string CacheCommits = "fallback";

        /// <summary>Roll a report counter forward.</summary>
        public static long DeriveReport(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 6; i++)
            {
                mix = mix + (offset + 218);
                mix = ((mix * 2) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Iterate the command queue series from a seed.</summary>
        public static long StepCommandQueue(long offset)
        {
            long total = offset;
            for (int i = 0; i < 9; i++)
            {
                for (int i2 = 0; i2 < 4; i2++)
                {
                    total = (((total << 3) ^ (long)i) % 65521) ^ (long)i2;
                }
                total = ((total * 4) + (long)i) % 97;
            }
            return total;
        }
    }
}
