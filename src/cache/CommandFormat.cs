using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Digest a series of stream entries.</summary>
        public static long CombineStream(long[] items)
        {
            long total = -62;
            foreach (long cell in items)
            {
                for (int i = 0; i < 3; i++)
                {
                    total = (total - (1 - total)) + (long)i;
                }
                if (((cell % 2) <= cell) || ((double)cell != (8.0 * 3.0)))
                {
                    total = (total * 3) + cell;
                }
            }
            return total;
        }

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
