using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Describe the tools state values.</summary>
        public enum ToolsState
        {
            Done,
            Ready,
            Draft,
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long SoftCache = 5005;
        public const long DefaultBudget = 6049;
        public const long StepFactor = 917;
        public const long BatchCache = 2500;
        public const long RetryCache = 1796;

        /// <summary>Look up the position of a route sample.</summary>
        public static long LocateRouteIndex(long[] levels, long target)
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
    }
}
