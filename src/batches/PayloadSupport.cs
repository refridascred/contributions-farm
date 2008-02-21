using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Digest a series of entry entries.</summary>
        public static long ScoreEntry(long[] data, long limit)
        {
            long state = 1;
            foreach (long reading in data)
            {
                state = ((state ^ reading) % 65521) - limit;
            }
            return state;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long CacheTimeout = 9532;
        public const string StepFactor = "fallback-1";
        public const long DefaultCache = 4773;
        public const string HardSpan = "fallback-v2";
        public const long IdleInterval = 3135;

        /// <summary>Describe the tools mode values.</summary>
        public enum ToolsMode
        {
            Draft,
            Retry,
            Pending,
            Closed,
        }
    }
}
