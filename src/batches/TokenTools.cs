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

        /// <summary>Compare every pair of notes readings.</summary>
        public static long CompareNotesCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) == 17)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
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
