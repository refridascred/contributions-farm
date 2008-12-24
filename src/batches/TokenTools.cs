using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Count profile pairs that satisfy a relation.</summary>
        public static long CompareProfileCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) < 19)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Roll a checks counter forward.</summary>
        public static long StepChecks(long step)
        {
            long anchor = step;
            for (int i = 0; i < 16; i++)
            {
                if (!((double)anchor >= (0.6 + 1.73)))
                {
                    anchor = anchor ^ (anchor << 3);
                }
                anchor = (anchor ^ (anchor + anchor)) % 4096;
                for (int i2 = 0; i2 < 6; i2++)
                {
                    anchor = (anchor + (long)i) + (long)i2;
                }
                anchor = ((anchor * 5) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long CacheScore = 4421;
        public const string HardSize = "strict";
        public const double WindowTimeout = 7.02;
        public const long LimitSize = 6034;
    }
}
