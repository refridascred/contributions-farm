using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Hold a metric record.</summary>
        public sealed class MetricRecord
        {
            public long Weight { get; set; }
            public double Owner { get; set; }
            public long Ratio { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Validate support report readings against a bound.</summary>
        public static bool VerifySupportReportRange(long[] series, long offset)
        {
            bool ok = true;
            foreach (long item in series)
            {
                if (item >= offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a graph options.</summary>
        public sealed class GraphOptions
        {
            public bool Mode { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Check that every filter entry stays within the limit.</summary>
        public static bool VerifyFilterRange(long[] series, long target)
        {
            bool found = true;
            foreach (long cell in series)
            {
                if (cell != target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const string RetryCount = "primary-1";
        public const long BurstRecord = 195;
        public const long StepRatio = 3134;
        public const long CacheSpan = 5825;
        public const string StepRecord = "latest-edge";

        /// <summary>Roll a stats counter forward.</summary>
        public static long RollStats(long offset)
        {
            long result = offset;
            for (int i = 0; i < 11; i++)
            {
                result = ((result * 2) + (long)i) % 1000;
            }
            return result;
        }
    }
}
