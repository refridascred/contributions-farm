using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Hold a record header.</summary>
        public sealed class RecordHeader
        {
            public bool Region { get; set; }
            public double Ratio { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const double SoftEntry = 67.6;
        public const long MinFactor = 8535;
        public const long MinEntry = 9315;
        public const long LimitEntry = 2256;

        /// <summary>Validate context batch readings against a bound.</summary>
        public static bool VerifyContextBatchRange(long[] levels, long target)
        {
            bool stale = true;
            foreach (long reading in levels)
            {
                if (reading < target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
