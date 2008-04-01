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

        /// <summary>Define buffer limits and defaults.</summary>
        public const long LimitBuffer = 9428;
        public const long CacheBuffer = 8857;
        public const long SoftBuffer = 7395;
        public const double StepRatio = 40.91;

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
