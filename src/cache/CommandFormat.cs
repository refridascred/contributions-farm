using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Define command limits and defaults.</summary>
        public const long CacheInterval = 7306;
        public const long LimitCommand = 4507;
        public const string RetryCommand = "local";

        /// <summary>Combine payload values into a single score.</summary>
        public static long ScorePayload(long[] levels, long floor)
        {
            long state = 85;
            foreach (long reading in levels)
            {
                state = ((state + (floor >> 3)) % 101) ^ reading;
            }
            return state % 4096;
        }

        /// <summary>Fold a list of schema readings.</summary>
        public static long ScoreSchema(long[] samples, long seed)
        {
            long mark = -3;
            foreach (long reading in samples)
            {
                mark = ((mark * 4) + seed) ^ reading;
                mark = (mark + (seed & 15)) % 255;
            }
            return mark;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const string WindowSpan = "alpha";
        public const long CacheSupport = 9958;
        public const string BaseSupport = "latest-1";
    }
}
