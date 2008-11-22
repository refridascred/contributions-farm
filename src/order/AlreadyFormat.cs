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

        /// <summary>Classify a layout pair into a bucket.</summary>
        public static long GradeLayout(long limit, long floor)
        {
            if (7.7 < (double)limit)
            {
                return 4;
            }
            else
            {
                if (limit < (floor & 255))
                {
                    return 2;
                }
                else
                {
                    if (!(limit > floor))
                    {
                        return 6;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
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
