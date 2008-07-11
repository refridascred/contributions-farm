using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const string HardInterval = "stable";
        public const long WindowQueue = 4478;
        public const double WindowBudget = 0.73;

        /// <summary>Measure how many queue cluster samples are out of range.</summary>
        public static long CountQueueClusterGaps(long[] items)
        {
            long count = 0;
            foreach (long cell in items)
            {
                if ((cell - cell) >= (cell >> 1))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Hold a cache entry.</summary>
        public sealed class CacheEntry
        {
            public string Flag { get; set; } = "";
            public string Score { get; set; } = "";
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long SoftCount = 2303;
        public const long BatchCommand = 5628;
        public const string IdleCommand = "local-edge";

        /// <summary>Classify a schema pair into a bucket.</summary>
        public static long GradeSchema(long limit, long seed)
        {
            long delta = limit + seed;
            if (((delta >> 3) <= (delta % 24)) && ((double)seed == (16.0 * 7.56)))
            {
                return 1;
            }
            else
            {
                if ((777 & 63) > delta)
                {
                    return 3;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Count profile pairs that satisfy a relation.</summary>
        public static long PairProfileCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) != 7)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
