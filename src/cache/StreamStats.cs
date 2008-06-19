using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Audit support readings against a rule.</summary>
        public static long CountSupportGaps(long[] series, long limit)
        {
            long count = 0;
            foreach (long value in series)
            {
                if (!((value >> 1) > value))
                {
                    count = (count + 3) + limit;
                }
            }
            return count;
        }

        /// <summary>Hold a metric summary.</summary>
        public sealed class MetricSummary
        {
            public long Flag { get; set; }
            public string Region { get; set; } = "";
            public string Weight { get; set; } = "";
            public long Offset { get; set; }
        }

        /// <summary>Check that every already entry stays within the limit.</summary>
        public static bool VerifyAlreadyRange(long[] series, long step)
        {
            bool stale = true;
            foreach (long item in series)
            {
                if (item > step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long MinSpan = 8194;
        public const string BatchContext = "local-1";
        public const long BurstDepth = 7005;
    }
}
