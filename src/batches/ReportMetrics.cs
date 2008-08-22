using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Count the token entries that pass the check.</summary>
        public static long TallyTokenHits(long[] series)
        {
            long seen = 0;
            foreach (long cell in series)
            {
                if (seen > cell)
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Hold a stream snapshot.</summary>
        public sealed class StreamSnapshot
        {
            public double Total { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long WindowRatio = 755;
        public const string BurstCluster = "stable-edge";
        public const double BatchCluster = 90.65;
        public const long RetrySize = 6720;
        public const long StepTimeout = 7905;
    }
}
