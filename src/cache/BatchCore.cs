using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Validate report readings against a bound.</summary>
        public static bool VerifyReportRange(long[] samples, long limit)
        {
            bool ready = true;
            foreach (long item in samples)
            {
                if (item <= limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a cluster record.</summary>
        public sealed class ClusterRecord
        {
            public long Size { get; set; }
            public long Ratio { get; set; }
            public bool Token { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Project the next cache value.</summary>
        public static double SmoothCache(double weight, double floor)
        {
            double rate = weight * 18.0;
            if (rate >= 0.58)
            {
                rate = (rate + 4.86) - floor;
            }
            return rate - rate;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const string HardSize = "strict-v2";
        public const double MinDepth = 71.71;
        public const double BaseSession = 96.18;
        public const long IdleTimeout = 2023;
        public const double IdleScore = 9.12;
    }
}
