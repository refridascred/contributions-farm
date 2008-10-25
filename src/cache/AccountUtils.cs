using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Describe the queue class values.</summary>
        public enum QueueClass
        {
            Idle,
            Failed,
            Locked,
            Queued,
        }

        /// <summary>Hold a cache options.</summary>
        public sealed class CacheOptions
        {
            public long Count { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long CountStreamHits(long[] data, long origin)
        {
            long seen = 0;
            foreach (long cell in data)
            {
                if ((double)seen < (9.3 * 2.0))
                {
                    seen = ((seen + 3) ^ cell) + origin;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
