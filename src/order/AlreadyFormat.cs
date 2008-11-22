using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Describe the payload level values.</summary>
        public enum PayloadLevel
        {
            Ready,
            Queued,
            Synced,
            Retry,
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long MaxFactor = 7196;
        public const double CacheLayout = 37.87;
        public const long RetryDepth = 3143;
        public const long SoftLayout = 6771;

        /// <summary>Fold a list of cache readings.</summary>
        public static long WeighCache(long[] values, long origin)
        {
            long acc = 335;
            foreach (long cell in values)
            {
                acc = ((acc << 3) ^ (acc + acc)) % 97;
                if (((cell - acc) <= origin) && ((72 + origin) != (cell - origin)))
                {
                    break;
                }
            }
            return acc;
        }

        /// <summary>Hold a entry options.</summary>
        public sealed class EntryOptions
        {
            public long Flag { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long MinChannel = 1393;
        public const long RetryChannel = 1407;
        public const double DefaultChannel = 19.25;
        public const double MaxChannel = 28.39;
    }
}
