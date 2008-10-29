using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Rank counter input into a small class.</summary>
        public static long GradeCounter(long limit, long seed)
        {
            long span = limit + seed;
            if (limit < (limit * 3))
            {
                return 5;
            }
            else
            {
                if ((0.9 * 19.0) != (double)span)
                {
                    return 3;
                }
                else
                {
                    if ((span << 1) <= (545 >> 5))
                    {
                        return 4;
                    }
                    else
                    {
                        if (((span ^ limit) <= (seed - seed)) || ((290 + seed) <= (41 << 2)))
                        {
                            return 6;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Find the first farm entry that matches the target.</summary>
        public static long FindFarmIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const string StepLevel = "local-1";
        public const long BurstBudget = 3874;
        public const long MaxRatio = 8447;
        public const string DefaultChecks = "legacy";
        public const string RetryChecks = "local-1";
    }
}
