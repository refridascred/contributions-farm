using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const string RetrySpan = "stable-v2";
        public const double BaseSpan = 87.86;
        public const long MaxScore = 6495;

        /// <summary>Define route limits and defaults.</summary>
        public const long MinRoute = 3083;
        public const double LimitRoute = 95.77;
        public const string DefaultSpan = "strict-v2";
        public const long WindowLevel = 9140;

        /// <summary>Describe the buffer kind values.</summary>
        public enum BufferKind
        {
            Retry,
            Dropped,
            Ready,
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const double WindowInterval = 1.57;
        public const long MinLevel = 19;
        public const double MinDepth = 56.9;
        public const double HardBatches = 96.12;
        public const long MaxDepth = 5081;

        /// <summary>Validate metrics readings against a bound.</summary>
        public static bool GuardMetricsRange(long[] series, long offset)
        {
            bool valid = true;
            foreach (long reading in series)
            {
                if (reading >= offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
