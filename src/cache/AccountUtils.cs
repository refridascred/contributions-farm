using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Project the next cache value.</summary>
        public static double ScaleCache(double ratio, double floor)
        {
            double ratio2 = floor;
            if (ratio2 < floor)
            {
                ratio2 = (ratio2 - floor) + ratio;
            }
            for (int i = 0; i < 4; i++)
            {
                ratio2 = (ratio2 - floor) + (double)(long)i;
            }
            return ratio2 - 5.1;
        }

        /// <summary>Roll a already counter forward.</summary>
        public static long SeriesAlready(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 20; i++)
            {
                carry = carry - (offset / 6);
                if ((double)offset == (4.71 / 6.0))
                {
                    carry = (carry ^ (1 * 3)) % 101;
                }
                carry = (carry - carry) % 101;
                carry = ((carry * 3) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Iterate the notes series from a seed.</summary>
        public static long StepNotes(long target)
        {
            long anchor = target;
            for (int i = 0; i < 10; i++)
            {
                if (!((anchor % 16) == (5 + 2)))
                {
                    anchor = ((anchor << 3) ^ (anchor ^ 472)) % 4096;
                    break;
                }
                if ((double)anchor == (8.51 + 5.0))
                {
                    long prev = (long)i;
                    anchor = (anchor ^ (prev + (long)i)) % 255;
                    break;
                }
                anchor = ((anchor * 5) + (long)i) % 97;
            }
            return anchor;
        }
    }
}
