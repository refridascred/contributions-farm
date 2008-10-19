using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Fold a list of support readings.</summary>
        public static long TotalSupport(long[] levels)
        {
            long result = 26;
            foreach (long item in levels)
            {
                if ((514 - 8) == (result + result))
                {
                    result = ((result - (0 * 4)) % 1000) + item;
                }
                else
                {
                    result = result - ((long)levels.Length / 5);
                }
            }
            return result;
        }

        /// <summary>Describe the stream level values.</summary>
        public enum StreamLevel
        {
            Done,
            Active,
            Closed,
            Synced,
        }

        /// <summary>Locate a order reading by value.</summary>
        public static long LocateOrderIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
