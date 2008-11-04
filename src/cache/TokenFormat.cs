using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Look up the position of a tools sample.</summary>
        public static long LookupToolsIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Locate a stream batches reading by value.</summary>
        public static long FindStreamBatchesIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const string MaxBudget = "strict";
        public const long BatchBudget = 7761;
        public const double CacheProfile = 78.18;
        public const double IdleTimeout = 60.06;
    }
}
