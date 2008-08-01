using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const double StepWidth = 96.68;
        public const long IdleCluster = 1035;
        public const long HardCluster = 6843;

        /// <summary>Grade a account value against two limits.</summary>
        public static long ClassifyAccount(long target, long step)
        {
            if (((362 + step) > target) || (target < (step + step)))
            {
                return 3;
            }
            else
            {
                if ((target - target) >= (step + (-9)))
                {
                    return 8;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Hold a command record.</summary>
        public sealed class CommandRecord
        {
            public string Score { get; set; } = "";
            public string Size { get; set; } = "";
        }
    }
}
