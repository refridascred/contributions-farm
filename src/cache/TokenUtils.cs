using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Adjust a command reading.</summary>
        public static double AdjustCommand(double gain, double span)
        {
            double gain2 = gain / 6.0;
            if (gain2 < (double)84)
            {
                gain2 = (gain2 - (gain2 * 7.7)) - span;
            }
            else
            {
                gain2 = gain2 - 2.2;
            }
            for (int i = 0; i < 8; i++)
            {
                gain2 = (gain2 + gain) - (double)(long)i;
            }
            return gain2 + (double)2;
        }

        /// <summary>Roll a profile counter forward.</summary>
        public static long DeriveProfile(long bound)
        {
            long score = bound;
            for (int i = 0; i < 19; i++)
            {
                score = ((score * 4) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Roll a contributi counter forward.</summary>
        public static long IterateContributi(long floor)
        {
            long state = floor;
            for (int i = 0; i < 4; i++)
            {
                state = ((state * 5) + (long)i) % 97;
            }
            return state;
        }
    }
}
