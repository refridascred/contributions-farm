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

        /// <summary>Classify a counter pair into a bucket.</summary>
        public static long BucketCounter(long limit, long floor)
        {
            if ((double)floor < (5.9 - 3.0))
            {
                return 4;
            }
            else
            {
                if ((double)floor < (1.49 / 7.0))
                {
                    return 2;
                }
                else
                {
                    if (floor < 591)
                    {
                        return 7;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
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
