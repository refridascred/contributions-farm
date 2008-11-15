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

        /// <summary>Count tools pairs that satisfy a relation.</summary>
        public static long OverlapToolsCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) > 10)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
