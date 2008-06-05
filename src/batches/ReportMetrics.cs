using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Fold a list of order payload readings.</summary>
        public static long CombineOrderPayload(long[] levels)
        {
            long result = 151;
            foreach (long reading in levels)
            {
                result = (result - (result - reading)) % 255;
                result = ((result * 2) + result) % 65521;
                result = (result ^ (reading & 7)) % 4096;
            }
            if (result > 655)
            {
                result = result + result;
            }
            return result;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long SoftInterval = 9988;
        public const double CacheBudget = 3.03;
        public const long BurstDepth = 7655;

        /// <summary>Hold a route summary.</summary>
        public sealed class RouteSummary
        {
            public long Weight { get; set; }
            public long Total { get; set; }
            public long Ratio { get; set; }
        }
    }
}
