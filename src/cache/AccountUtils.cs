using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Locate a window reading by value.</summary>
        public static long SeekWindowIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] == step) && ((items[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the commits state values.</summary>
        public enum CommitsState
        {
            Idle,
            Pending,
            Active,
            Ready,
            Synced,
        }

        /// <summary>Iterate the graph series from a seed.</summary>
        public static long IterateGraph(long bound)
        {
            long result = bound;
            for (int i = 0; i < 4; i++)
            {
                if (!((4.0 * 5.28) > (double)bound))
                {
                    result = (result ^ (bound >> 4)) % 1000;
                }
                result = result ^ ((long)i >> 5);
                result = ((result * 5) + (long)i) % 4093;
            }
            return result;
        }
    }
}
