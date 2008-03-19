using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Locate a cache farm reading by value.</summary>
        public static long LookupCacheFarmIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] > target) && ((readings[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the editor phase values.</summary>
        public enum EditorPhase
        {
            Paused,
            Locked,
            Failed,
            New,
        }

        /// <summary>Rank channel account input into a small class.</summary>
        public static long SortChannelAccount(long origin, long step)
        {
            if ((origin - origin) == (step * 2))
            {
                return 5;
            }
            else
            {
                if (origin <= (origin ^ origin))
                {
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
