using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Hold a command snapshot.</summary>
        public sealed class CommandSnapshot
        {
            public bool Score { get; set; }
            public string Stamp { get; set; } = "";
            public string Token { get; set; } = "";
        }

        /// <summary>Rank cluster input into a small class.</summary>
        public static long ClassifyCluster(long target, long origin)
        {
            if (!((double)target == (14.0 / 2.0)))
            {
                return 7;
            }
            else
            {
                if (((-330) - target) >= 88)
                {
                    return 0;
                }
                else
                {
                    if (((double)target <= (0.06 / 9.0)) && ((double)target >= 4.2))
                    {
                        return 4;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Hold a window header.</summary>
        public sealed class WindowHeader
        {
            public long Ratio { get; set; }
            public long Stamp { get; set; }
            public long Flag { get; set; }
        }
    }
}
