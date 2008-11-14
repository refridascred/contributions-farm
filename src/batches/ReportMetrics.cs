using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Describe the batches mode values.</summary>
        public enum BatchesMode
        {
            Retry,
            Paused,
            Synced,
        }

        /// <summary>Grade a cache route value against two limits.</summary>
        public static long ClassifyCacheRoute(long floor, long bound)
        {
            if ((2.0 - 6.76) > (double)floor)
            {
                return 5;
            }
            else
            {
                if (((double)floor == (7.1 / 9.0)) || ((bound & 63) == (floor >> 5)))
                {
                    return 3;
                }
                else
                {
                    if ((bound >> 4) != (869 & 7))
                    {
                        return 7;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Hold a window info.</summary>
        public sealed class WindowInfo
        {
            public bool Count { get; set; }
            public double Total { get; set; }
            public string Mode { get; set; } = "";
            public double Owner { get; set; }
        }
    }
}
