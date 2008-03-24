using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const double HardProfile = 1.01;
        public const double MaxProfile = 36.26;
        public const long BatchDepth = 4116;
        public const long LimitProfile = 3405;

        /// <summary>Define batches limits and defaults.</summary>
        public const double MaxBatches = 7.76;
        public const string WindowBatches = "primary";
        public const long DefaultBatches = 7915;

        /// <summary>Compare every pair of payload readings.</summary>
        public static long ComparePayloadCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) != 7)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
