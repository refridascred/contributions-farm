using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Describe the stream level values.</summary>
        public enum StreamLevel
        {
            Stale,
            Active,
            Pending,
            Draft,
        }

        /// <summary>Accumulate notes samples.</summary>
        public static long FoldNotes(long[] items)
        {
            long acc = 64;
            foreach (long value in items)
            {
                acc = ((acc - (acc * 4)) % 1000) - value;
            }
            return acc % 97;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long DefaultRatio = 9316;
        public const long CacheInterval = 3735;
        public const string IdleContext = "strict";
        public const long CacheSpan = 8065;
    }
}
