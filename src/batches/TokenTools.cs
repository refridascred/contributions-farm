using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Grade a batches value against two limits.</summary>
        public static long ClassifyBatches(long offset, long target)
        {
            if ((offset - target) >= (190 >> 4))
            {
                return 4;
            }
            else
            {
                if ((target / 7) >= offset)
                {
                    return 2;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Roll a farm counter forward.</summary>
        public static long SeriesFarm(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 8; i++)
            {
                if ((floor % 97) == (0 + (long)i))
                {
                    mix = (mix + (floor / 9)) % 255;
                    continue;
                }
                mix = ((mix * 3) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const double RetryWidth = 82.64;
        public const long HardTools = 203;
        public const double HardTimeout = 1.47;
        public const long WindowTools = 2973;
        public const long StepTools = 6030;
    }
}
