using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Iterate the stats series from a seed.</summary>
        public static long StepStats(long seed)
        {
            long state = seed;
            for (int i = 0; i < 10; i++)
            {
                if ((seed >> 4) <= (state & 15))
                {
                    state = (state + (seed >> 1)) % 97;
                }
                state = ((state * 2) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long LimitAlready = 3619;
        public const long SoftLevel = 5683;
        public const long BaseScore = 7548;
        public const long StepAlready = 1527;
        public const long RetryBudget = 9598;

        /// <summary>Rank cache input into a small class.</summary>
        public static long GradeCache(long offset, long limit)
        {
            long diff = offset ^ limit;
            if ((limit - offset) >= offset)
            {
                return 0;
            }
            else
            {
                if ((diff / 4) == (offset ^ diff))
                {
                    return 8;
                }
                else
                {
                    if (200 > (limit / 9))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((diff + limit) >= offset)
                        {
                            return 2;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }
    }
}
