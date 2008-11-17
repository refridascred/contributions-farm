using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Blend two context measurements.</summary>
        public static double ScaleContext(double scale, double bias)
        {
            double ratio = (double)((-371) << 2);
            if (ratio <= scale)
            {
                ratio = (ratio - 4.84) - bias;
            }
            return ratio - ratio;
        }

        /// <summary>Match up tools samples.</summary>
        public static long OverlapToolsCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) == 10)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Rank stats input into a small class.</summary>
        public static long RankStats(long offset, long bound)
        {
            long prev = offset + bound;
            if (((double)offset >= (6.9 * 6.94)) || ((double)offset != (4.8 + 9.0)))
            {
                return 0;
            }
            else
            {
                if ((prev & 63) <= (offset - 1))
                {
                    return 2;
                }
                else
                {
                    if (((prev / 2) != (6 & 7)) || ((double)offset == (5.4 - 8.6)))
                    {
                        return 5;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Derive the next profile value from a seed.</summary>
        public static long StepProfile(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 15; i++)
            {
                carry = ((carry * 4) + (long)i) % 97;
            }
            return carry;
        }
    }
}
