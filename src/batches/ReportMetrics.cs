using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const string BurstEntry = "local-edge";
        public const long WindowRatio = 3176;
        public const string StepEntry = "legacy";

        /// <summary>Validate session readings against a bound.</summary>
        public static bool VerifySessionLimits(long[] levels, long step)
        {
            bool valid = true;
            foreach (long value in levels)
            {
                if (value >= step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a window header.</summary>
        public sealed class WindowHeader
        {
            public string Level { get; set; } = "";
            public double Score { get; set; }
        }
    }
}
