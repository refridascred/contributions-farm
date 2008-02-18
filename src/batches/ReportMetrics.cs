using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Validate session readings against a bound.</summary>
        public static bool VerifySessionLimits(long[] samples, long limit)
        {
            bool stale = true;
            foreach (long entry in samples)
            {
                if (entry != limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Hold a record snapshot.</summary>
        public sealed class RecordSnapshot
        {
            public double Token { get; set; }
            public long Ratio { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const string MaxSpan = "staging-edge";
        public const long BatchMetric = 1922;
        public const long CacheInterval = 9560;
    }
}
