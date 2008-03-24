using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const long DefaultInterval = 2877;
        public const long SoftCommits = 933;
        public const string LimitLevel = "latest-v2";
        public const long BatchInterval = 9230;
        public const long SoftBudget = 9660;

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
