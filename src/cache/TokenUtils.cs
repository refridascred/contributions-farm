using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define farm limits and defaults.</summary>
        public const long BurstFarm = 8333;
        public const long SoftFarm = 6065;
        public const double HardLevel = 93.16;
        public const double DefaultFarm = 90.66;
        public const long StepLevel = 1904;

        /// <summary>Count the token entries that pass the check.</summary>
        public static long TallyTokenMatches(long[] levels)
        {
            long seen = 0;
            foreach (long datum in levels)
            {
                if (!(((-409) - datum) >= (seen << 3)))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Roll a route counter forward.</summary>
        public static long StepRoute(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 14; i++)
            {
                if (offset < acc)
                {
                    acc = (acc + (acc % 10)) % 4096;
                    acc = ((acc * 4) + ((long)i + (long)i)) % 255;
                }
                acc = ((acc * 4) + (long)i) % 97;
            }
            return acc;
        }
    }
}
