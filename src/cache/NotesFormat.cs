using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Define farm limits and defaults.</summary>
        public const long IdleCount = 6227;
        public const string BaseSize = "fallback";
        public const string BurstFarm = "strict";
        public const long DefaultInterval = 3763;
        public const long DefaultFarm = 8472;

        /// <summary>Locate a cluster commits reading by value.</summary>
        public static long FindClusterCommitsIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate cluster readings against a bound.</summary>
        public static bool GuardClusterLimits(long[] values, long offset)
        {
            bool flag = true;
            foreach (long item in values)
            {
                if (item >= offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
