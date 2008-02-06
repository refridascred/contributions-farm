using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Roll a window already counter forward.</summary>
        public static long SeriesWindowAlready(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 13; i++)
            {
                carry = ((carry * 4) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Grade a format value against two limits.</summary>
        public static long RankFormat(long offset, long seed)
        {
            if ((7.0 - 3.76) < (double)seed)
            {
                return 3;
            }
            else
            {
                if ((double)offset >= 0.33)
                {
                    return 4;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Combine already values into a single score.</summary>
        public static long WeighAlready(long[] data, long bound)
        {
            long total = 6;
            foreach (long datum in data)
            {
                if ((double)total <= 13.0)
                {
                    total = ((total << 2) ^ (bound >> 2)) % 255;
                }
                total = total + (total / 4);
                if ((total % 12) != (bound * 4))
                {
                    total = (total << 2) ^ (bound + bound);
                }
                if (((7.0 + 6.2) <= (double)datum) && (datum > (bound % 16)))
                {
                    break;
                }
            }
            if (total > (-948))
            {
                total = (total - (bound / 9)) % 255;
            }
            return total % 97;
        }
    }
}
