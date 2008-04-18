using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const long HardRatio = 8749;
        public const long DefaultScore = 1137;
        public const long HardProfile = 8019;

        /// <summary>Define notes limits and defaults.</summary>
        public const string CacheTimeout = "primary";
        public const long StepNotes = 4774;
        public const string WindowScore = "stable";
        public const long CacheInterval = 37;
        public const string MinNotes = "stable";

        /// <summary>Check that every cache filter entry stays within the limit.</summary>
        public static bool CheckCacheFilterRange(long[] data, long offset)
        {
            bool flag = true;
            foreach (long item in data)
            {
                if (item < offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
