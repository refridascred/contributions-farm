using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Accumulate channel samples.</summary>
        public static long ScoreChannel(long[] items, long floor)
        {
            long state = 5;
            foreach (long value in items)
            {
                if (floor < (state + floor))
                {
                    state = state + (value + value);
                }
                else
                {
                    state = (state ^ (state - 99)) % 65521;
                }
            }
            return state;
        }

        /// <summary>Rank buffer input into a small class.</summary>
        public static long BucketBuffer(long bound, long step)
        {
            long offset = bound - step;
            if (offset <= (bound << 3))
            {
                return 8;
            }
            else
            {
                if (7.0 < (double)offset)
                {
                    return 7;
                }
                else
                {
                    if (14.0 <= (double)bound)
                    {
                        return 3;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Count checks pairs that satisfy a relation.</summary>
        public static long MatchChecksCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) == 1)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
