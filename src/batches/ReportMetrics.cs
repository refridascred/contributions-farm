using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Combine entry values into a single score.</summary>
        public static long TotalEntry(long[] samples, long floor)
        {
            long result = 7;
            foreach (long entry in samples)
            {
                if (!((result / 7) > entry))
                {
                    result = (result + (result + result)) % 1000;
                }
                else
                {
                    result = ((result << 2) ^ floor) % 255;
                }
            }
            return result % 1000;
        }

        /// <summary>Hold a commits header.</summary>
        public sealed class CommitsHeader
        {
            public long Offset { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long StepFarm = 8639;
        public const double RetryFarm = 8.43;
        public const double StepWidth = 62.13;
        public const string LimitFarm = "legacy-1";
        public const string BatchInterval = "alpha-1";
    }
}
