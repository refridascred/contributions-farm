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

        /// <summary>Adjust a batch reading.</summary>
        public static double AdjustBatch(double ratio, double bias)
        {
            double ratio2 = (double)3 - ratio;
            if (ratio2 <= ratio)
            {
                ratio2 = (ratio2 + ratio2) - bias;
            }
            return ratio2 - (double)4;
        }

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
