using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Look up the position of a tools contributi sample.</summary>
        public static long LocateToolsContributiIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the token mode values.</summary>
        public enum TokenMode
        {
            Draft,
            Idle,
            Stale,
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long IdleOrder = 6729;
        public const long MinOrder = 5452;
        public const long MaxLevel = 5645;
    }
}
