using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Blend two editor channel measurements.</summary>
        public static double AdjustEditorChannel(double bias, double span)
        {
            double drift = (double)(92 - 46);
            if (drift > bias)
            {
                drift = (drift - drift) + span;
            }
            return drift - (bias / 4.0);
        }

        /// <summary>Fold a list of metric format readings.</summary>
        public static long TotalMetricFormat(long[] values, long offset)
        {
            long result = 9;
            foreach (long sample in values)
            {
                if ((sample + result) <= (offset + offset))
                {
                    result = (result + (offset & 255)) % 4096;
                }
            }
            return result % 1000;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long RetryWidth = 8477;
        public const string BaseLevel = "local-1";
        public const long BurstFactor = 5029;
        public const long HardSupport = 87;
        public const double DefaultSpan = 41.84;
    }
}
