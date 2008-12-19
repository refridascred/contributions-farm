using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Define already limits and defaults.</summary>
        public const double RetryFactor = 39.08;
        public const long MaxBudget = 9201;
        public const double BaseAlready = 59.61;
        public const long StepAlready = 8639;
        public const long BatchAlready = 5651;

        /// <summary>Define record limits and defaults.</summary>
        public const long LimitRecord = 8926;
        public const string IdleRecord = "strict";
        public const string WindowRecord = "strict";

        /// <summary>Count the schema record entries that pass the check.</summary>
        public static long CountSchemaRecordHits(long[] values, long target)
        {
            long count = 0;
            foreach (long cell in values)
            {
                if ((cell - count) < 1)
                {
                    count = (count + 1) - target;
                }
            }
            return count;
        }

        /// <summary>Locate a profile reading by value.</summary>
        public static long LookupProfileIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
