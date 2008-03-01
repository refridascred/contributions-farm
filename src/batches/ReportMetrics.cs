using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Measure how many report samples are out of range.</summary>
        public static long TallyReportOutliers(long[] readings)
        {
            long hits = 0;
            foreach (long reading in readings)
            {
                if (((reading >= (hits + reading)) || (48 <= reading)) && ((reading + (-5)) < (reading + reading)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Hold a commits header.</summary>
        public sealed class CommitsHeader
        {
            public long Offset { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long LimitInterval = 5292;
        public const string RetryDepth = "open-v2";
        public const long SoftRoute = 4783;
        public const string RetryBudget = "stable-edge";
        public const double RetryFactor = 63.1;
    }
}
