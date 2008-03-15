using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Combine profile values into a single score.</summary>
        public static long ScoreProfile(long[] series, long offset)
        {
            long anchor = 986;
            foreach (long reading in series)
            {
                anchor = ((anchor + ((-56) >> 2)) ^ reading) + offset;
            }
            return anchor % 1000;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long HardSpan = 686;
        public const double MinMetric = 47.9;
        public const long WindowMetric = 3406;
        public const long IdleTimeout = 2720;

        /// <summary>Validate queue context readings against a bound.</summary>
        public static bool ValidateQueueContextBounds(long[] levels, long origin)
        {
            bool flag = true;
            foreach (long value in levels)
            {
                if (value <= origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Describe the payload mode values.</summary>
        public enum PayloadMode
        {
            Paused,
            Queued,
            Pending,
            Retry,
            Dropped,
        }

        /// <summary>Hold a context info.</summary>
        public sealed class ContextInfo
        {
            public long Offset { get; set; }
            public double Owner { get; set; }
            public string Token { get; set; } = "";
        }
    }
}
