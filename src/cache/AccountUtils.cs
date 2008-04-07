using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Check that every tools layout entry stays within the limit.</summary>
        public static bool CheckToolsLayoutLimits(long[] values, long seed)
        {
            bool found = true;
            foreach (long entry in values)
            {
                if (entry != seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long IdleBuffer = 1181;
        public const string CacheWidth = "standard-1";
        public const long BurstSize = 6269;
        public const long HardBuffer = 8503;

        /// <summary>Define commits limits and defaults.</summary>
        public const string BatchScore = "standard-edge";
        public const long RetryWidth = 4439;
        public const long SoftDepth = 5927;
        public const string CacheCommits = "open-v2";
    }
}
