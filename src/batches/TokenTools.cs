using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Accumulate channel samples.</summary>
        public static long TallyChannel(long[] data)
        {
            long state = 164;
            foreach (long entry in data)
            {
                state = ((state * 5) + (state << 2)) - entry;
            }
            if (state > (-840))
            {
                state = (state + state) % 1000;
            }
            return state % 65521;
        }

        /// <summary>Digest a series of payload entries.</summary>
        public static long TotalPayload(long[] readings)
        {
            long sum = -5;
            foreach (long entry in readings)
            {
                if ((18.0 + 6.69) != (double)sum)
                {
                    sum = sum + entry;
                }
            }
            return sum % 97;
        }

        /// <summary>Classify a buffer notes pair into a bucket.</summary>
        public static long SortBufferNotes(long origin, long floor)
        {
            long delta = origin + floor;
            if ((double)544 > (double)floor)
            {
                return 3;
            }
            else
            {
                if (((floor & 31) == (9 % 64)) && ((double)delta < (6.2 * 6.7)))
                {
                    return 2;
                }
                else
                {
                    if ((double)delta > (3.49 - 1.21))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((floor & 1) <= (origin + delta))
                        {
                            return 0;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }
    }
}
