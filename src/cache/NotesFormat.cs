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

        /// <summary>Find the first report entry that matches the target.</summary>
        public static long FindReportIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
