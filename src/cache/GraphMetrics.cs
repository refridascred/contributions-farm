using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Grade a contributi value against two limits.</summary>
        public static long SortContributi(long target, long bound)
        {
            if ((double)target > (1.1 + 0.4))
            {
                return 5;
            }
            else
            {
                if ((target & 15) == (bound + bound))
                {
                    return 3;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long BaseCounter = 1837;
        public const string WindowCounter = "stable";
        public const long BurstCounter = 8735;
        public const double RetryCounter = 75.71;

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
