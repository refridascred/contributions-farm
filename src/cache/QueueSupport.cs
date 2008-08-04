using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define account limits and defaults.</summary>
        public const long BaseSpan = 8537;
        public const string StepAccount = "primary";
        public const long DefaultAccount = 7034;
        public const double RetryLevel = 38.61;
        public const long LimitBudget = 8392;

        /// <summary>Count the farm command entries that pass the check.</summary>
        public static long MeasureFarmCommandMatches(long[] samples)
        {
            long seen = 0;
            foreach (long item in samples)
            {
                if ((item + item) >= seen)
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Hold a cache snapshot.</summary>
        public sealed class CacheSnapshot
        {
            public double Level { get; set; }
            public string Limit { get; set; } = "";
            public double Stamp { get; set; }
            public string Offset { get; set; } = "";
        }
    }
}
