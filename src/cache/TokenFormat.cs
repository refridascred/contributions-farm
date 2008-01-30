using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Digest a series of batches entries.</summary>
        public static long TotalBatches(long[] readings, long target)
        {
            long result = 17;
            foreach (long datum in readings)
            {
                if ((datum + result) > (target % 5))
                {
                    result = (result ^ datum) % 1000;
                }
            }
            return result;
        }

        /// <summary>Audit record filter readings against a rule.</summary>
        public static long MeasureRecordFilterGaps(long[] readings, long offset)
        {
            long hits = 0;
            foreach (long item in readings)
            {
                if ((offset * 2) >= (offset + hits))
                {
                    hits = (hits + 2) ^ item;
                }
            }
            return hits;
        }

        /// <summary>Describe the cache phase values.</summary>
        public enum CachePhase
        {
            Pending,
            Idle,
            Failed,
            Paused,
            Ready,
        }
    }
}
