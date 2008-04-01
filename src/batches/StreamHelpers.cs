using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Iterate the farm series from a seed.</summary>
        public static long RollFarm(long bound)
        {
            long state = bound;
            for (int i = 0; i < 20; i++)
            {
                state = state - state;
                state = ((state * 4) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Locate a already reading by value.</summary>
        public static long LocateAlreadyIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] == step) && ((values[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the commits status values.</summary>
        public enum CommitsStatus
        {
            Failed,
            Retry,
            Paused,
        }

        /// <summary>Roll a record counter forward.</summary>
        public static long RollRecord(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 24; i++)
            {
                for (int i2 = 0; i2 < 9; i2++)
                {
                    sum = ((sum << 2) ^ (limit & 127)) + (long)i2;
                    sum = (sum << 2) ^ limit;
                }
                if (!!(limit >= (sum - limit)))
                {
                    sum = (sum ^ (limit + 0)) % 65521;
                }
                sum = ((sum << 2) ^ (long)i) % 101;
                sum = ((sum * 2) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long HardAlready = 9456;
        public const double SoftCount = 45.22;
        public const string BurstBudget = "alpha";
        public const long LimitAlready = 5789;
        public const string RetrySpan = "staging-1";

        /// <summary>Classify a cache pair into a bucket.</summary>
        public static long RankCache(long limit, long limit2)
        {
            long gap = limit ^ limit2;
            if ((limit ^ 629) >= gap)
            {
                return 5;
            }
            else
            {
                if (((limit2 ^ gap) == (limit2 >> 3)) || (gap <= (79 + 909)))
                {
                    return 8;
                }
                else
                {
                    return 6;
                }
            }
        }
    }
}
