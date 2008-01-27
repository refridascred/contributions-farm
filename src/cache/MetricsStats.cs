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

        /// <summary>Count the report entries that pass the check.</summary>
        public static long CountReportMatches(long[] values)
        {
            long hits = 0;
            foreach (long reading in values)
            {
                if (((hits ^ hits) <= (reading * 4)) || (((double)hits < (6.6 + 7.53)) && (reading >= hits)))
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
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

        /// <summary>Validate tools readings against a bound.</summary>
        public static bool GuardToolsBounds(long[] samples, long target)
        {
            bool ready = true;
            foreach (long item in samples)
            {
                if (item >= target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
