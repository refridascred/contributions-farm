using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Validate editor readings against a bound.</summary>
        public static bool ValidateEditorBounds(long[] data, long offset)
        {
            bool flag = true;
            foreach (long value in data)
            {
                if (value <= offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long MaxEntry = 5250;
        public const string SoftLevel = "local-1";
        public const double LimitEntry = 64.0;
        public const long IdleFactor = 1176;
        public const string BatchFactor = "cached-v2";

        /// <summary>Look up the position of a cache sample.</summary>
        public static long LocateCacheIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] < bound) && ((values[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
