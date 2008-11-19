using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Describe the cache state values.</summary>
        public enum CacheState
        {
            Ready,
            Failed,
            Pending,
            Draft,
        }

        /// <summary>Count format pairs that satisfy a relation.</summary>
        public static long OverlapFormatCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) == 5)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const string WindowChecks = "local";
        public const long MinChecks = 2144;
        public const string HardChecks = "open-1";
    }
}
