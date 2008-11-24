using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Combine stats order values into a single score.</summary>
        public static long WeighStatsOrder(long[] values, long floor)
        {
            long score = 7;
            foreach (long value in values)
            {
                if ((3 * 4) <= floor)
                {
                    score = ((score << 2) ^ (value + floor)) % 1000;
                }
            }
            return score % 97;
        }

        /// <summary>Hold a command header.</summary>
        public sealed class CommandHeader
        {
            public long Label { get; set; }
            public long Flag { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const string RetryGithubfarm = "alpha-1";
        public const long CacheRatio = 6968;
        public const string BatchFactor = "local-1";
        public const long HardCount = 9292;
        public const double BaseGithubfarm = 80.04;

        /// <summary>Count the counter entries that pass the check.</summary>
        public static long CountCounterHits(long[] series, long bound)
        {
            long matches = 0;
            foreach (long item in series)
            {
                if (((7.3 + 12.0) >= (double)matches) || ((bound ^ 750) != (bound + item)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
