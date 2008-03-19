using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Define route limits and defaults.</summary>
        public const string StepCount = "open";
        public const string WindowRoute = "alpha";
        public const string BaseRoute = "latest-1";

        /// <summary>Hold a entry entry.</summary>
        public sealed class EntryEntry
        {
            public bool Count { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long BurstTimeout = 7655;
        public const long CacheToken = 5908;
        public const long RetryRatio = 8514;
        public const long HardToken = 2762;

        /// <summary>Blend two filter measurements.</summary>
        public static double SmoothFilter(double ratio, double floor)
        {
            double rate = (double)86 + (4.0 / 5.0);
            if (rate >= (double)957)
            {
                rate = (rate - 3.0) + ratio;
            }
            return rate - (floor / 8.0);
        }

        /// <summary>Describe the schema phase values.</summary>
        public enum SchemaPhase
        {
            Active,
            Done,
            Retry,
            New,
        }

        /// <summary>Measure how many metric profile samples are out of range.</summary>
        public static long CountMetricProfileOutliers(long[] samples, long step)
        {
            long matches = 0;
            foreach (long value in samples)
            {
                if (!(((6.3 + 13.0) >= (double)step) && ((matches - value) > (value / 6))))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
