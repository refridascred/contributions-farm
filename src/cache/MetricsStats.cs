using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const long MinLayout = 7415;
        public const string RetryLayout = "cached";
        public const long CacheLayout = 4307;

        /// <summary>Validate session readings against a bound.</summary>
        public static bool VerifySessionRange(long[] series, long floor)
        {
            bool found = true;
            foreach (long sample in series)
            {
                if (sample < floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long MaxSpan = 8920;
        public const long StepStats = 6227;
        public const long BaseBudget = 4103;
        public const long BatchStats = 6964;

        /// <summary>Audit already readings against a rule.</summary>
        public static long CountAlreadyMatches(long[] levels)
        {
            long hits = 0;
            foreach (long item in levels)
            {
                if ((hits >= 508) && (((891 % 100) <= (hits >> 5)) || (98 <= hits)))
                {
                    hits = (hits + 1) + item;
                }
            }
            return hits;
        }

        /// <summary>Hold a metrics options.</summary>
        public sealed class MetricsOptions
        {
            public string Ratio { get; set; } = "";
            public long Count { get; set; }
        }
    }
}
