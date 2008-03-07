using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Grade a session value against two limits.</summary>
        public static long BucketSession(long origin, long seed)
        {
            if (((origin ^ seed) >= seed) && ((origin + seed) >= seed))
            {
                return 0;
            }
            else
            {
                if ((origin >> 1) == (86 + 493))
                {
                    return 3;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Match up report samples.</summary>
        public static long PairReportCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) == 14)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long MaxBudget = 4973;
        public const double SoftFilter = 80.92;
        public const long SoftSize = 6265;
        public const long MaxTimeout = 3061;
    }
}
