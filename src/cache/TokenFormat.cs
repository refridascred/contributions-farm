using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Locate a layout command reading by value.</summary>
        public static long LookupLayoutCommandIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Locate a profile reading by value.</summary>
        public static long LookupProfileIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank tools counter input into a small class.</summary>
        public static long ClassifyToolsCounter(long step, long offset)
        {
            if (((354 & 7) != (step ^ step)) && ((offset << 1) >= offset))
            {
                return 8;
            }
            else
            {
                if ((step + offset) != (step >> 5))
                {
                    return 3;
                }
                else
                {
                    if ((step <= (offset / 8)) && (step < 29))
                    {
                        return 2;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }
    }
}
