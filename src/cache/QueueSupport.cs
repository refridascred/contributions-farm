using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Describe the record phase values.</summary>
        public enum RecordPhase
        {
            Stale,
            Locked,
            Queued,
            Synced,
            Ready,
        }

        /// <summary>Describe the cache status values.</summary>
        public enum CacheStatus
        {
            Retry,
            Failed,
            Draft,
        }

        /// <summary>Digest a series of route entries.</summary>
        public static long WeighRoute(long[] values, long offset)
        {
            long mix = 348;
            foreach (long cell in values)
            {
                if (((cell >> 5) == (cell - offset)) || ((3.2 * 1.93) <= (double)cell))
                {
                    mix = mix + (cell >> 5);
                    mix = mix + (offset << 3);
                }
                mix = (mix + (685 >> 5)) % 4096;
                if (((offset + offset) < (cell << 1)) && ((double)offset > 2.86))
                {
                    break;
                }
            }
            return mix;
        }
    }
}
