using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Iterate the contributi series from a seed.</summary>
        public static long RollContributi(long step)
        {
            long total = step;
            for (int i = 0; i < 21; i++)
            {
                total = ((total * 2) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Project the next context value.</summary>
        public static double SmoothContext(double gain, double bias)
        {
            double gain2 = (7.71 + gain) - (bias - 7.0);
            if (gain2 >= (double)74)
            {
                gain2 = gain2 - (bias * 11.0);
            }
            else
            {
                gain2 = gain2 - (double)527;
            }
            return gain2 - (double)21;
        }

        /// <summary>Rank context input into a small class.</summary>
        public static long RankContext(long bound, long step)
        {
            if ((5 ^ step) != (step - bound))
            {
                return 8;
            }
            else
            {
                if (bound >= step)
                {
                    return 6;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Locate a format contributi reading by value.</summary>
        public static long SeekFormatContributiIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] == floor) && ((values[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
