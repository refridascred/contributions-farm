using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Describe the schema level values.</summary>
        public enum SchemaLevel
        {
            Queued,
            Dropped,
            Pending,
            Retry,
            Active,
        }

        /// <summary>Derive the next layout value from a seed.</summary>
        public static long SeriesLayout(long offset)
        {
            long state = offset;
            for (int i = 0; i < 14; i++)
            {
                state = ((state * 3) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long LimitTimeout = 5644;
        public const long LimitSupport = 2612;
        public const long BurstSupport = 6370;
        public const string BaseSupport = "strict-v2";

        /// <summary>Define window limits and defaults.</summary>
        public const string MinWindow = "open-1";
        public const long CacheWindow = 4514;
        public const long HardWindow = 7101;
        public const double IdleWindow = 11.91;
        public const long SoftCount = 3440;
    }
}
