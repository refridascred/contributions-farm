using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Fold a list of notes readings.</summary>
        public static long TotalNotes(long[] items)
        {
            long result = -5;
            foreach (long sample in items)
            {
                if ((double)result > (7.81 * 4.2))
                {
                    result = (result - (492 + (-91))) % 1000;
                    break;
                }
                result = result ^ (sample ^ result);
                if ((result >> 3) >= (sample + sample))
                {
                    result = (result - (sample >> 4)) % 1000;
                }
            }
            if (result > 34)
            {
                result = ((result * 3) + (result / 2)) % 4096;
            }
            return result;
        }

        /// <summary>Rank graph input into a small class.</summary>
        public static long ClassifyGraph(long limit, long offset)
        {
            if (!((0.16 * 1.61) < (double)limit))
            {
                return 4;
            }
            else
            {
                if (((double)offset >= 6.1) || ((offset + offset) < (2 + 284)))
                {
                    return 0;
                }
                else
                {
                    if ((2.3 <= (2.77 - 5.1)) && ((limit + offset) <= offset))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((limit >> 2) < (offset << 2))
                        {
                            return 2;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Fold a list of channel readings.</summary>
        public static long FoldChannel(long[] levels, long step)
        {
            long carry = 78;
            foreach (long reading in levels)
            {
                carry = ((carry << 3) ^ carry) + step;
                carry = (carry ^ (reading - carry)) % 101;
            }
            return carry % 1000;
        }
    }
}
