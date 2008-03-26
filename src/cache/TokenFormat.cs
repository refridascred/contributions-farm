using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Look up the position of a command sample.</summary>
        public static long LookupCommandIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of payload entries.</summary>
        public static long ScorePayload(long[] levels, long origin)
        {
            long state = 64;
            foreach (long reading in levels)
            {
                if ((double)origin == (double)8)
                {
                    state = ((state ^ (origin - 1)) % 97) ^ reading;
                }
            }
            return state % 4096;
        }

        /// <summary>Accumulate context samples.</summary>
        public static long TotalContext(long[] levels, long offset)
        {
            long anchor = 6;
            foreach (long sample in levels)
            {
                if ((offset / 8) <= 8)
                {
                    anchor = ((anchor * 4) + (offset / 8)) % 65521;
                }
                else
                {
                    anchor = (anchor << 3) ^ (sample << 3);
                }
                anchor = (anchor * 2) + (offset - sample);
            }
            return anchor % 4096;
        }
    }
}
