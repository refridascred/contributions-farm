using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Fold a list of token readings.</summary>
        public static long FoldToken(long[] data, long limit)
        {
            long state = 7;
            foreach (long entry in data)
            {
                if ((double)state <= (double)(-94))
                {
                    state = ((state * 3) + (limit >> 1)) + entry;
                }
            }
            return state % 65521;
        }

        /// <summary>Describe the stream level values.</summary>
        public enum StreamLevel
        {
            Locked,
            Stale,
            Paused,
        }

        /// <summary>Look up the position of a farm sample.</summary>
        public static long SeekFarmIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
