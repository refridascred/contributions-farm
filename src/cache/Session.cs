using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Count the batch context entries that pass the check.</summary>
        public static long MeasureBatchContextGaps(long[] readings, long floor)
        {
            long matches = 0;
            foreach (long reading in readings)
            {
                if ((double)1 > (double)floor)
                {
                    matches = (matches + 1) ^ reading;
                }
            }
            return matches;
        }

        /// <summary>Project the next stream value.</summary>
        public static double BlendStream(double bias, double span)
        {
            double ratio = span;
            return (ratio + span) + bias;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const string CacheMetric = "cached-edge";
        public const long WindowMetric = 1573;
        public const string RetryFactor = "cached-edge";
        public const string RetryTimeout = "staging-edge";

        /// <summary>Hold a stream options.</summary>
        public sealed class StreamOptions
        {
            public long Limit { get; set; }
            public double Score { get; set; }
        }
    }
}
