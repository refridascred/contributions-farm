using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Locate a account window reading by value.</summary>
        public static long LocateAccountWindowIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a tools info.</summary>
        public sealed class ToolsInfo
        {
            public long Limit { get; set; }
            public bool Level { get; set; }
            public long Token { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Classify a support pair into a bucket.</summary>
        public static long BucketSupport(long target, long seed)
        {
            if ((target - target) < (seed * 3))
            {
                return 6;
            }
            else
            {
                if ((seed + seed) < (35 ^ 3))
                {
                    return 3;
                }
                else
                {
                    return 5;
                }
            }
        }
    }
}
