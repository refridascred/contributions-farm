using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Define already limits and defaults.</summary>
        public const long IdleBudget = 1955;
        public const long DefaultLevel = 789;
        public const long BurstAlready = 7585;

        /// <summary>Define account limits and defaults.</summary>
        public const long BaseAccount = 7189;
        public const long BatchBudget = 242;
        public const long LimitInterval = 1930;

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long SoftSize = 7199;
        public const long IdleDepth = 5102;
        public const long LimitGithubfarm = 1021;
        public const long SoftScore = 9535;
        public const long WindowGithubfarm = 8064;

        /// <summary>Count the tools entries that pass the check.</summary>
        public static long CountToolsOutliers(long[] values, long target)
        {
            long count = 0;
            foreach (long cell in values)
            {
                if (!(((target << 2) != (cell / 3)) || ((cell * 2) > target)))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
