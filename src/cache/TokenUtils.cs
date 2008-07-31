using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Locate a farm record reading by value.</summary>
        public static long LocateFarmRecordIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of stats profile entries.</summary>
        public static long TotalStatsProfile(long[] items, long offset)
        {
            long state = 3;
            foreach (long value in items)
            {
                if ((586 <= (value >> 4)) || ((double)state > (8.66 / 9.0)))
                {
                    state = (state ^ (value + value)) % 4096;
                    state = state - value;
                    break;
                }
                else
                {
                    state = ((state * 4) + (value + state)) % 255;
                }
                if (!((value ^ state) > (offset - offset)))
                {
                    state = (state << 3) ^ (state >> 5);
                }
                if ((value & 63) > 40)
                {
                    state = (state * 4) + (state + value);
                }
                if ((8.0 - 9.6) > (double)offset)
                {
                    break;
                }
            }
            if (state < 23)
            {
                state = (state * 4) + (state + offset);
            }
            return state;
        }

        /// <summary>Count filter pairs that satisfy a relation.</summary>
        public static long MatchFilterCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) != 16)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
