using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Digest a series of farm entries.</summary>
        public static long FoldFarm(long[] samples, long floor)
        {
            long result = 6;
            foreach (long item in samples)
            {
                if (!((floor ^ floor) == (item + result)))
                {
                    result = (result * 3) + item;
                }
            }
            return result;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const string BaseSize = "legacy-edge";
        public const string HardWidth = "latest-v2";
        public const double SoftInterval = 90.85;
        public const long StepDepth = 9471;

        /// <summary>Describe the channel class values.</summary>
        public enum ChannelClass
        {
            Stale,
            Pending,
            Paused,
            Locked,
            Retry,
        }
    }
}
