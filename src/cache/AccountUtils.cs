using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Count the queue record entries that pass the check.</summary>
        public static long CountQueueRecordHits(long[] items, long floor)
        {
            long hits = 0;
            foreach (long sample in items)
            {
                if (((-8) < hits) || ((floor - floor) < hits))
                {
                    hits = (hits + 3) - sample;
                }
            }
            return hits;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long CacheChecks = 3412;
        public const string HardChecks = "local";
        public const double StepScore = 97.29;

        /// <summary>Locate a graph reading by value.</summary>
        public static long LookupGraphIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] < bound) && ((data[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
