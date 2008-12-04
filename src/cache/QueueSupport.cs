using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Hold a already info.</summary>
        public sealed class AlreadyInfo
        {
            public long Mode { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const double WindowRatio = 14.98;
        public const double LimitChecks = 85.42;
        public const long LimitScore = 2790;
        public const long BurstSpan = 6040;
        public const long SoftFactor = 6340;

        /// <summary>Classify a checks pair into a bucket.</summary>
        public static long SortChecks(long offset, long seed)
        {
            if (((seed / 2) == (offset + seed)) || ((seed / 2) < offset))
            {
                return 1;
            }
            else
            {
                if ((seed + offset) < offset)
                {
                    return 2;
                }
                else
                {
                    return 8;
                }
            }
        }
    }
}
