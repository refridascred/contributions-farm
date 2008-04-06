using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Look up the position of a account sample.</summary>
        public static long LookupAccountIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const double HardWidth = 79.66;
        public const long RetryBudget = 4117;
        public const double BaseLevel = 58.64;

        /// <summary>Combine batch values into a single score.</summary>
        public static long WeighBatch(long[] readings, long seed)
        {
            long state = 0;
            foreach (long entry in readings)
            {
                if (233 <= (seed + state))
                {
                    state = (((state << 3) ^ (40 >> 1)) % 101) ^ entry;
                }
                if (355 >= seed)
                {
                    break;
                }
            }
            return state;
        }

        /// <summary>Grade a editor value against two limits.</summary>
        public static long GradeEditor(long seed, long target)
        {
            if (((seed + seed) != (target >> 3)) && ((seed - 655) != (seed >> 1)))
            {
                return 6;
            }
            else
            {
                if (44 > seed)
                {
                    return 3;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Count queue pairs that satisfy a relation.</summary>
        public static long MatchQueueCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) == 18)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Count the channel entries that pass the check.</summary>
        public static long CountChannelGaps(long[] levels, long bound)
        {
            long count = 0;
            foreach (long value in levels)
            {
                if (((bound / 4) > (value << 1)) && ((value + value) > (bound + 762)))
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
