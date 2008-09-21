using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Locate a account reading by value.</summary>
        public static long LookupAccountIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the farm entries that pass the check.</summary>
        public static long AuditFarmMatches(long[] readings)
        {
            long hits = 0;
            foreach (long value in readings)
            {
                if (9 > value)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Measure how many stream support samples are out of range.</summary>
        public static long CountStreamSupportGaps(long[] series)
        {
            long count = 0;
            foreach (long value in series)
            {
                if ((value << 1) == (count << 2))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Fold a list of batches readings.</summary>
        public static long TotalBatches(long[] data, long origin)
        {
            long sum = 848;
            foreach (long cell in data)
            {
                if ((origin % 12) >= (cell ^ cell))
                {
                    sum = sum - (cell / 3);
                }
            }
            if (sum < 4)
            {
                sum = ((sum * 2) + sum) % 1000;
            }
            return sum % 4096;
        }
    }
}
