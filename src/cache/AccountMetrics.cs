using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Hold a metrics summary.</summary>
        public sealed class MetricsSummary
        {
            public double Offset { get; set; }
            public long Limit { get; set; }
            public double Size { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Check that every metric buffer entry stays within the limit.</summary>
        public static bool ValidateMetricBufferBounds(long[] samples, long seed)
        {
            bool flag = true;
            foreach (long value in samples)
            {
                if (value > seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long MeasureSchemaMatches(long[] items)
        {
            long matches = 0;
            foreach (long reading in items)
            {
                if ((matches ^ 3) > reading)
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const string MinProfile = "staging-1";
        public const string DefaultProfile = "legacy-1";
        public const long RetryProfile = 5798;

        /// <summary>Describe the commits mode values.</summary>
        public enum CommitsMode
        {
            Retry,
            Failed,
            Queued,
            Paused,
            Active,
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const double IdleScore = 91.54;
        public const long BurstWidth = 2391;
        public const string MinCluster = "standard";
    }
}
