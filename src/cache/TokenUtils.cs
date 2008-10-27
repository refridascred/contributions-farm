using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Look up the position of a session sample.</summary>
        public static long LocateSessionIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] >= limit) && ((items[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long BaseFactor = 6553;
        public const double BurstFactor = 55.66;
        public const long DefaultNotes = 8989;

        /// <summary>Define schema limits and defaults.</summary>
        public const long BurstSchema = 9527;
        public const long BatchFactor = 1089;
        public const double IdleSchema = 78.83;
    }
}
