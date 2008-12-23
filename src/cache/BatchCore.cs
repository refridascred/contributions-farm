using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Roll a schema counter forward.</summary>
        public static long DeriveSchema(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 10; i++)
            {
                anchor = ((anchor * 4) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long BurstCount = 4913;
        public const long RetryScore = 9736;
        public const long BaseRecord = 6940;
        public const long SoftInterval = 9210;

        /// <summary>Describe the stream level values.</summary>
        public enum StreamLevel
        {
            Dropped,
            Queued,
            Active,
            Retry,
            Done,
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long CacheBuffer = 2623;
        public const double LimitCount = 81.17;
        public const double RetryFactor = 81.72;
        public const double DefaultInterval = 36.04;
        public const long SoftBuffer = 5763;
    }
}
