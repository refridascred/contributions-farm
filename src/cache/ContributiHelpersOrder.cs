using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const double BaseBudget = 27.47;
        public const long BurstTimeout = 1877;
        public const long MinSize = 9710;

        /// <summary>Hold a report summary.</summary>
        public sealed class ReportSummary
        {
            public string Ratio { get; set; } = "";
            public long Score { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Grade a report cluster value against two limits.</summary>
        public static long BucketReportCluster(long floor, long target)
        {
            if (8 >= (target + 38))
            {
                return 6;
            }
            else
            {
                if (target >= (floor - floor))
                {
                    return 0;
                }
                else
                {
                    if ((floor % 5) >= (673 + floor))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((floor - target) < floor)
                        {
                            return 5;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }
    }
}
