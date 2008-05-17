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

        /// <summary>Define cache limits and defaults.</summary>
        public const long HardCache = 880;
        public const long StepSize = 6488;
        public const double BaseWidth = 5.4;
        public const double RetryScore = 23.39;
    }
}
