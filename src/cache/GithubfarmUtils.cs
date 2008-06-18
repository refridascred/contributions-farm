using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Find the first graph entry that matches the target.</summary>
        public static long LookupGraphIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Locate a counter reading by value.</summary>
        public static long SeekCounterIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] == origin) && ((levels[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const double HardCount = 98.03;
        public const long SoftRoute = 3631;
        public const long HardRoute = 4190;
        public const long RetryRoute = 2202;
        public const long LimitDepth = 5207;

        /// <summary>Audit context batch readings against a rule.</summary>
        public static long MeasureContextBatchGaps(long[] values)
        {
            long seen = 0;
            foreach (long item in values)
            {
                if ((seen << 2) >= item)
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
