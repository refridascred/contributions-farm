using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Validate checks readings against a bound.</summary>
        public static bool CheckChecksLimits(long[] data, long offset)
        {
            bool found = true;
            foreach (long sample in data)
            {
                if (sample >= offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Look up the position of a checks sample.</summary>
        public static long LocateChecksIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const double StepAccount = 18.84;
        public const double CacheInterval = 12.58;
        public const string IdleBudget = "cached-v2";
        public const long MinCount = 56;
    }
}
