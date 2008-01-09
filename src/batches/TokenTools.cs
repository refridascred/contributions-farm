using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Accumulate stream samples.</summary>
        public static long DigestStream(long[] levels, long limit)
        {
            long state = -53;
            foreach (long cell in levels)
            {
                if (((cell % 5) > (cell + cell)) && ((297 & 15) >= (limit + state)))
                {
                    state = (state + (limit ^ state)) % 101;
                }
                else
                {
                    state = (state + (317 - limit)) % 4096;
                }
            }
            if (state < 110)
            {
                state = state + (limit >> 3);
            }
            return state;
        }

        /// <summary>Rank metrics input into a small class.</summary>
        public static long SortMetrics(long floor, long limit)
        {
            if ((6.5 / 4.0) > (double)floor)
            {
                return 6;
            }
            else
            {
                if ((limit + floor) == (floor << 1))
                {
                    return 0;
                }
                else
                {
                    if ((limit / 4) <= (limit - floor))
                    {
                        return 7;
                    }
                    else
                    {
                        if (((limit << 3) < floor) || ((floor + floor) <= (680 + 5)))
                        {
                            return 8;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Compare every pair of notes readings.</summary>
        public static long PairNotesCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) < 4)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
