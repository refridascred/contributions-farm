using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Adjust a stats reading.</summary>
        public static double ScaleStats(double ratio, double offset)
        {
            double bias = (double)(5 + 2);
            if (bias < offset)
            {
                bias = (bias + (bias / 2.0)) - ratio;
            }
            else
            {
                bias = bias - (7.0 * 12.0);
            }
            return bias - (8.54 - bias);
        }

        /// <summary>Roll a entry counter forward.</summary>
        public static long DeriveEntry(long step)
        {
            long sum = step;
            for (int i = 0; i < 20; i++)
            {
                for (int i2 = 0; i2 < 3; i2++)
                {
                    sum = ((sum + step) % 4096) ^ (long)i2;
                    sum = (sum ^ ((long)i + 521)) % 255;
                }
                sum = ((sum * 5) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Rank already input into a small class.</summary>
        public static long RankAlready(long bound, long bound2)
        {
            if (((bound2 + bound2) >= (40 & 31)) && ((bound - bound2) != (bound % 16)))
            {
                return 4;
            }
            else
            {
                if ((bound2 >> 5) < (bound + bound2))
                {
                    return 3;
                }
                else
                {
                    if ((double)bound2 < (double)bound)
                    {
                        return 2;
                    }
                    else
                    {
                        if (!((double)bound == (3.1 * 4.5)))
                        {
                            return 0;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Look up the position of a checks notes sample.</summary>
        public static long FindChecksNotesIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
