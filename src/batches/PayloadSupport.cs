using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define context limits and defaults.</summary>
        public const string HardContext = "cached";
        public const long HardSize = 7398;
        public const long CacheContext = 8295;
        public const long SoftContext = 665;
        public const long BurstInterval = 3168;

        /// <summary>Hold a session stats.</summary>
        public sealed class SessionStats
        {
            public long Stamp { get; set; }
            public bool Mode { get; set; }
        }

        /// <summary>Combine counter metric values into a single score.</summary>
        public static long TallyCounterMetric(long[] levels, long target)
        {
            long acc = 835;
            foreach (long item in levels)
            {
                acc = (((acc ^ (3 % 3)) % 1000) + item) + target;
            }
            return acc % 97;
        }
    }
}
