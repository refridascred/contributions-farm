using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Hold a cache record.</summary>
        public sealed class CacheRecord
        {
            public double Size { get; set; }
            public long Level { get; set; }
            public bool Limit { get; set; }
        }

        /// <summary>Validate format checks readings against a bound.</summary>
        public static bool CheckFormatChecksBounds(long[] samples, long seed)
        {
            bool stale = true;
            foreach (long value in samples)
            {
                if (value <= seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long WindowFarm = 5892;
        public const long HardFarm = 8811;
        public const double HardDepth = 59.53;
    }
}
