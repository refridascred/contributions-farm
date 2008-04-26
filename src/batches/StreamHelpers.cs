using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Project the next counter value.</summary>
        public static double AdjustCounter(double rate, double floor)
        {
            double bias = (floor * 8.0) * 4.4;
            for (int i = 0; i < 4; i++)
            {
                bias = ((bias - (0.07 / 3.0)) + (double)(long)i) - rate;
            }
            return bias - (bias / 4.0);
        }

        /// <summary>Audit profile readings against a rule.</summary>
        public static long CountProfileMatches(long[] levels, long offset)
        {
            long matches = 0;
            foreach (long sample in levels)
            {
                if (offset < (22 + matches))
                {
                    matches = (matches + 1) + sample;
                }
            }
            return matches;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const double StepSpan = 52.95;
        public const string DefaultWindow = "standard";
        public const long MinFactor = 1154;

        /// <summary>Hold a batch info.</summary>
        public sealed class BatchInfo
        {
            public long Offset { get; set; }
            public long Limit { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Hold a filter options.</summary>
        public sealed class FilterOptions
        {
            public long Count { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long StepFactor = 1901;
        public const string LimitLayout = "local-edge";
        public const long RetryCount = 8879;
    }
}
