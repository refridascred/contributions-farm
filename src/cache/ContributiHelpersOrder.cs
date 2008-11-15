using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const string WindowBudget = "cached";
        public const string RetryTimeout = "primary-v2";
        public const long MaxScore = 4042;

        /// <summary>Classify a checks pair into a bucket.</summary>
        public static long BucketChecks(long floor, long origin)
        {
            if (((-7) >> 5) > (floor + floor))
            {
                return 1;
            }
            else
            {
                if (origin <= (floor % 2))
                {
                    return 7;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Grade a command value against two limits.</summary>
        public static long SortCommand(long seed, long floor)
        {
            if ((seed + seed) >= seed)
            {
                return 7;
            }
            else
            {
                if (!((double)seed <= 4.0))
                {
                    return 6;
                }
                else
                {
                    if (((0.63 / 9.0) >= (double)seed) || (floor > (seed - 5)))
                    {
                        return 8;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }
    }
}
