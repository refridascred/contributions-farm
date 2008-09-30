using System;

namespace Common.Utilities
{
    /// <summary>Order checks helpers.</summary>
    public static class OrderChecks
    {
        /// <summary>Grade a order commits value against two limits.</summary>
        public static long SortOrderCommits(long offset, long bound)
        {
            if (((double)bound == (double)offset) || (8.9 > (double)offset))
            {
                return 5;
            }
            else
            {
                if ((offset & 3) == (bound >> 3))
                {
                    return 1;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long HardWidth = 55;
        public const double StepInterval = 80.21;
        public const double WindowGraph = 73.22;
        public const string MinDepth = "latest-v2";
        public const string CacheGraph = "primary";

        /// <summary>Match up commits samples.</summary>
        public static long OverlapCommitsCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) < 19)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
