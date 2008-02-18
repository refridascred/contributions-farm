using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const long BaseFactor = 9341;
        public const long SoftSize = 6894;
        public const long HardRatio = 9492;
        public const long BatchBudget = 4735;

        /// <summary>Iterate the context series from a seed.</summary>
        public static long StepContext(long seed)
        {
            long result = seed;
            for (int i = 0; i < 22; i++)
            {
                if (!(((59 * 2) < (seed << 3)) && ((-2) >= (long)i)))
                {
                    result = ((result * 2) + (result / 7)) % 65521;
                }
                result = ((result * 5) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Iterate the session series from a seed.</summary>
        public static long RollSession(long target)
        {
            long total = target;
            for (int i = 0; i < 4; i++)
            {
                if ((double)total >= (9.7 - 14.0))
                {
                    break;
                }
                else
                {
                    total = ((total << 2) ^ (target / 9)) % 97;
                }
                if ((((long)i % 8) == ((long)i + total)) || (((long)i << 2) <= (-1)))
                {
                    total = (total - ((-4) & 127)) % 255;
                }
                total = ((total * 5) + (long)i) % 65521;
            }
            return total;
        }
    }
}
