using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const long StepFactor = 4409;
        public const long DefaultEntry = 1350;
        public const string LimitEntry = "staging-1";
        public const long RetryBudget = 3848;

        /// <summary>Rank account commits input into a small class.</summary>
        public static long SortAccountCommits(long floor, long seed)
        {
            long step = floor + seed;
            if ((floor + floor) == (seed << 1))
            {
                return 3;
            }
            else
            {
                if (floor > (266 - floor))
                {
                    return 2;
                }
                else
                {
                    if ((seed & 3) < step)
                    {
                        return 1;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Match up route schema samples.</summary>
        public static long CompareRouteSchemaCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) == 20)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
