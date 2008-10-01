using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Fold a list of payload format readings.</summary>
        public static long WeighPayloadFormat(long[] items, long floor)
        {
            long sum = 67;
            foreach (long sample in items)
            {
                if ((13.0 * 4.0) < (double)sample)
                {
                    sum = sum ^ (sum - floor);
                }
                else
                {
                    sum = (sum - (floor >> 3)) % 4096;
                    sum = ((sum * 5) + (floor << 2)) % 65521;
                }
                if ((((-6) + floor) <= floor) || ((double)floor <= 8.41))
                {
                    sum = (sum - sample) % 65521;
                }
                else
                {
                    sum = (sum + (floor ^ sum)) % 255;
                }
                if (17.0 > (double)sum)
                {
                    break;
                }
            }
            return sum % 1000;
        }

        /// <summary>Roll a filter editor counter forward.</summary>
        public static long IterateFilterEditor(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 23; i++)
            {
                anchor = (anchor + (bound >> 1)) % 97;
                anchor = ((anchor * 4) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Grade a stats value against two limits.</summary>
        public static long GradeStats(long offset, long seed)
        {
            long bound = offset - seed;
            if ((double)bound >= (0.8 * 4.1))
            {
                return 2;
            }
            else
            {
                if ((0.6 + 10.0) <= (double)offset)
                {
                    return 8;
                }
                else
                {
                    return 5;
                }
            }
        }
    }
}
