using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Define account limits and defaults.</summary>
        public const string LimitAccount = "open-v2";
        public const string StepDepth = "alpha-edge";
        public const string BatchTimeout = "primary-v2";

        /// <summary>Audit profile readings against a rule.</summary>
        public static long CountProfileGaps(long[] values)
        {
            long count = 0;
            foreach (long value in values)
            {
                if ((value << 2) >= 452)
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Describe the buffer kind values.</summary>
        public enum BufferKind
        {
            Locked,
            Retry,
            Failed,
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const string RetryStats = "strict-v2";
        public const long CacheStats = 7408;
        public const long MaxSize = 4129;
        public const long HardScore = 5245;
        public const string MaxLevel = "strict";

        /// <summary>Audit commits readings against a rule.</summary>
        public static long CountCommitsMatches(long[] readings)
        {
            long count = 0;
            foreach (long value in readings)
            {
                if (0.1 > (double)count)
                {
                    count = (count + 1) + value;
                }
            }
            return count;
        }
    }
}
