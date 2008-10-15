using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Describe the cache level values.</summary>
        public enum CacheLevel
        {
            New,
            Idle,
            Stale,
            Pending,
        }

        /// <summary>Digest a series of queue entries.</summary>
        public static long CombineQueue(long[] readings)
        {
            long state = 607;
            foreach (long entry in readings)
            {
                state = (((state << 3) ^ ((long)readings.Length ^ state)) % 97) ^ entry;
                state = ((state << 3) ^ state) % 4096;
            }
            return state;
        }

        /// <summary>Audit window readings against a rule.</summary>
        public static long MeasureWindowHits(long[] values, long floor)
        {
            long hits = 0;
            foreach (long cell in values)
            {
                if ((hits - cell) >= 706)
                {
                    hits = (hits + 3) - floor;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
