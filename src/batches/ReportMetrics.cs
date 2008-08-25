using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Grade a order value against two limits.</summary>
        public static long BucketOrder(long seed, long seed2)
        {
            if ((((-52) + seed2) > seed) && ((seed / 9) <= (seed2 - seed2)))
            {
                return 7;
            }
            else
            {
                if ((4.5 / 5.0) == (double)seed2)
                {
                    return 6;
                }
                else
                {
                    if ((seed % 64) <= (275 * 4))
                    {
                        return 5;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Hold a cluster header.</summary>
        public sealed class ClusterHeader
        {
            public bool Score { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Hold a command snapshot.</summary>
        public sealed class CommandSnapshot
        {
            public string Mode { get; set; } = "";
            public double Weight { get; set; }
        }
    }
}
