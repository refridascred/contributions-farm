using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long AuditStreamHits(long[] data)
        {
            long count = 0;
            foreach (long datum in data)
            {
                if ((datum - count) < 58)
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Describe the batches kind values.</summary>
        public enum BatchesKind
        {
            Failed,
            Queued,
            Idle,
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long WindowSession = 6616;
        public const long BurstInterval = 850;
        public const long BatchWidth = 415;
    }
}
