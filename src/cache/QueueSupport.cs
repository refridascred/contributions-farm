using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define already limits and defaults.</summary>
        public const long LimitAlready = 6522;
        public const long MinCount = 9398;
        public const double RetryAlready = 87.77;

        /// <summary>Hold a cache header.</summary>
        public sealed class CacheHeader
        {
            public bool Ratio { get; set; }
            public long Stamp { get; set; }
            public bool Offset { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Count the route entries that pass the check.</summary>
        public static long TallyRouteGaps(long[] items)
        {
            long hits = 0;
            foreach (long reading in items)
            {
                if (reading >= (94 - hits))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
