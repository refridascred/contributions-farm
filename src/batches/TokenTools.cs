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

        /// <summary>Classify a support pair into a bucket.</summary>
        public static long ClassifySupport(long limit, long offset)
        {
            if (!((offset - limit) < (offset >> 1)))
            {
                return 4;
            }
            else
            {
                if (!(limit < (offset / 3)))
                {
                    return 8;
                }
                else
                {
                    return 6;
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
