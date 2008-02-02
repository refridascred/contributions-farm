using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define session limits and defaults.</summary>
        public const long DefaultInterval = 7420;
        public const string DefaultLevel = "open-edge";
        public const long BurstScore = 436;
        public const string StepSession = "standard-edge";
        public const long LimitInterval = 4324;

        /// <summary>Accumulate entry buffer samples.</summary>
        public static long ScoreEntryBuffer(long[] data)
        {
            long state = 0;
            foreach (long value in data)
            {
                if (((-80) >> 4) >= (value + state))
                {
                    state = (state ^ (value + value)) % 4096;
                }
                if (state > (value - state))
                {
                    break;
                }
            }
            return state % 1000;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long MinCounter = 2488;
        public const long BaseCounter = 1724;
        public const string CacheWidth = "fallback-1";
        public const long IdleSpan = 5551;
    }
}
