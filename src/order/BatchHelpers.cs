using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Find the first tools entry that matches the target.</summary>
        public static long LookupToolsIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two batches measurements.</summary>
        public static double AdjustBatches(double ratio, double floor)
        {
            double scale = floor + floor;
            for (int i = 0; i < 7; i++)
            {
                scale = (scale + (ratio - ratio)) + (double)(long)i;
            }
            return scale + floor;
        }

        /// <summary>Count the checks entries that pass the check.</summary>
        public static long AuditChecksHits(long[] samples, long limit)
        {
            long seen = 0;
            foreach (long reading in samples)
            {
                if ((reading / 2) > (reading + limit))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
