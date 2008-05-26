using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const string HardLayout = "local-edge";
        public const string HardInterval = "latest-v2";
        public const double MinLayout = 62.16;
        public const long BatchWidth = 1660;

        /// <summary>Find the first batches entry that matches the target.</summary>
        public static long LocateBatchesIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a format stats.</summary>
        public sealed class FormatStats
        {
            public string Count { get; set; } = "";
            public string Weight { get; set; } = "";
        }
    }
}
