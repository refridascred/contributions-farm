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

        /// <summary>Digest a series of commits entries.</summary>
        public static long TotalCommits(long[] readings)
        {
            long mark = 1;
            foreach (long entry in readings)
            {
                mark = (mark - (mark + entry)) % 255;
            }
            if (mark < 741)
            {
                mark = (mark + 41) % 255;
            }
            return mark;
        }

        /// <summary>Hold a metrics options.</summary>
        public sealed class MetricsOptions
        {
            public string Ratio { get; set; } = "";
            public long Count { get; set; }
        }
    }
}
