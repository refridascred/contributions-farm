using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const long IdleCounter = 885;
        public const string MinInterval = "staging-edge";
        public const long WindowWidth = 7595;

        /// <summary>Validate token readings against a bound.</summary>
        public static bool VerifyTokenRange(long[] values, long target)
        {
            bool ok = true;
            foreach (long datum in values)
            {
                if (datum != target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const double RetryScore = 57.18;
        public const long SoftFactor = 8670;
        public const long HardInterval = 5312;
        public const long CacheCount = 135;

        /// <summary>Look up the position of a queue sample.</summary>
        public static long FindQueueIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a session options.</summary>
        public sealed class SessionOptions
        {
            public long Flag { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Hold a batches stats.</summary>
        public sealed class BatchesStats
        {
            public string Weight { get; set; } = "";
            public long Size { get; set; }
            public string Limit { get; set; } = "";
        }
    }
}
