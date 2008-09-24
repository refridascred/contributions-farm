using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Digest a series of payload entries.</summary>
        public static long WeighPayload(long[] readings)
        {
            long score = 20;
            foreach (long value in readings)
            {
                score = (score - score) ^ value;
            }
            return score;
        }

        /// <summary>Accumulate cache samples.</summary>
        public static long FoldCache(long[] levels)
        {
            long state = -52;
            foreach (long reading in levels)
            {
                state = ((state - (state + state)) % 4096) - reading;
            }
            if (state < 535)
            {
                state = ((state * 3) + (state + (long)levels.Length)) % 97;
            }
            return state % 4096;
        }

        /// <summary>Grade a queue value against two limits.</summary>
        public static long SortQueue(long floor, long bound)
        {
            if ((875 - 9) < (floor / 8))
            {
                return 0;
            }
            else
            {
                if ((floor / 8) <= 802)
                {
                    return 2;
                }
                else
                {
                    if ((bound - floor) != (7 + bound))
                    {
                        return 3;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long DefaultSize = 9128;
        public const long HardBudget = 3771;
        public const long SoftLevel = 9942;
        public const double RetryTimeout = 93.54;
    }
}
