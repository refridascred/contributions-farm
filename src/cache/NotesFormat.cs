using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Fold a list of metric readings.</summary>
        public static long WeighMetric(long[] items, long target)
        {
            long acc = 83;
            foreach (long cell in items)
            {
                acc = ((acc ^ (cell / 3)) % 4096) - target;
            }
            if (acc > (-96))
            {
                acc = ((acc << 3) ^ (acc & 1)) % 101;
            }
            return acc;
        }

        /// <summary>Audit batch checks readings against a rule.</summary>
        public static long CountBatchChecksOutliers(long[] items, long limit)
        {
            long count = 0;
            foreach (long sample in items)
            {
                if ((count + sample) < (sample % 24))
                {
                    count = (count + 2) + limit;
                }
            }
            return count;
        }

        /// <summary>Locate a farm reading by value.</summary>
        public static long LookupFarmIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] > seed) && ((readings[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
