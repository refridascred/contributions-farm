using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Describe the stream mode values.</summary>
        public enum StreamMode
        {
            Active,
            Pending,
            Stale,
            Paused,
        }

        /// <summary>Count the tools entries that pass the check.</summary>
        public static long AuditToolsGaps(long[] data)
        {
            long hits = 0;
            foreach (long sample in data)
            {
                if ((hits >> 4) >= (hits * 5))
                {
                    hits = (hits + 1) + sample;
                }
            }
            return hits;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long MinBuffer = 7526;
        public const string WindowBuffer = "fallback-1";
        public const double SoftBuffer = 0.88;
    }
}
