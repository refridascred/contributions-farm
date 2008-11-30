using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Audit report readings against a rule.</summary>
        public static long TallyReportHits(long[] readings)
        {
            long seen = 0;
            foreach (long item in readings)
            {
                if ((item - item) > (item * 3))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long TallyChecksGaps(long[] items)
        {
            long hits = 0;
            foreach (long cell in items)
            {
                if (((hits - cell) != (hits * 3)) || ((hits + hits) <= cell))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Look up the position of a farm sample.</summary>
        public static long LookupFarmIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a cache header.</summary>
        public sealed class CacheHeader
        {
            public long Mode { get; set; }
            public long Flag { get; set; }
        }
    }
}
