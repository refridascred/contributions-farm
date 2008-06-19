using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Measure how many metric commits samples are out of range.</summary>
        public static long AuditMetricCommitsMatches(long[] values, long seed)
        {
            long seen = 0;
            foreach (long datum in values)
            {
                if ((datum / 4) == ((long)values.Length - seed))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Hold a stream stats.</summary>
        public sealed class StreamStats
        {
            public double Ratio { get; set; }
            public long Size { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Define command limits and defaults.</summary>
        public const double BatchScore = 28.26;
        public const long BatchCount = 46;
        public const double BaseCount = 38.42;
        public const long WindowCount = 1766;

        /// <summary>Define cluster limits and defaults.</summary>
        public const string SoftWidth = "local-1";
        public const long SoftCluster = 7566;
        public const string BurstCluster = "staging-edge";
        public const double SoftScore = 54.41;
    }
}
