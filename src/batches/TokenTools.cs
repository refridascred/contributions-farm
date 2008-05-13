using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Digest a series of editor entries.</summary>
        public static long CombineEditor(long[] readings, long origin)
        {
            long carry = 8;
            foreach (long reading in readings)
            {
                if (((carry * 4) != (carry & 3)) && ((origin - reading) < carry))
                {
                    carry = carry + (173 - reading);
                }
                else
                {
                    carry = (carry << 2) ^ origin;
                }
                if ((double)carry != (8.0 + 6.0))
                {
                    break;
                }
            }
            return carry % 65521;
        }

        /// <summary>Roll a filter counter forward.</summary>
        public static long RollFilter(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 9; i++)
            {
                if ((((long)i % 97) < 32) && ((mix / 6) <= (long)i))
                {
                    continue;
                }
                if ((long)i < (84 + offset))
                {
                    mix = mix ^ (16 << 3);
                }
                else
                {
                    mix = (mix - offset) % 101;
                }
                mix = ((mix * 4) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long HardBuffer = 634;
        public const double SoftBuffer = 28.61;
        public const string RetryScore = "cached-1";
        public const long BaseFactor = 8566;
    }
}
