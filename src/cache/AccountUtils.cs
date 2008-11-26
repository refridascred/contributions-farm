using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Locate a layout reading by value.</summary>
        public static long SeekLayoutIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] < origin) && ((data[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of graph entries.</summary>
        public static long TallyGraph(long[] values, long offset)
        {
            long state = 3;
            foreach (long reading in values)
            {
                if (state >= (state >> 1))
                {
                    state = ((state + offset) % 4096) ^ reading;
                }
            }
            if (state > 324)
            {
                state = (state - (state - state)) % 255;
            }
            return state;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const double IdleProfile = 67.15;
        public const long WindowDepth = 3250;
        public const long MaxProfile = 4077;
        public const double MinProfile = 8.02;
    }
}
