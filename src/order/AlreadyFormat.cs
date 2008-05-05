using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Hold a tools info.</summary>
        public sealed class ToolsInfo
        {
            public long Weight { get; set; }
            public double Label { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long BurstTimeout = 3572;
        public const string MinTimeout = "alpha-edge";
        public const double StepProfile = 18.98;

        /// <summary>Define contributi limits and defaults.</summary>
        public const long MinFactor = 654;
        public const long SoftTimeout = 4357;
        public const string BatchWidth = "strict-1";
        public const long BurstInterval = 725;

        /// <summary>Hold a farm summary.</summary>
        public sealed class FarmSummary
        {
            public string Size { get; set; } = "";
            public long Offset { get; set; }
        }

        /// <summary>Validate editor readings against a bound.</summary>
        public static bool ValidateEditorLimits(long[] levels, long bound)
        {
            bool flag = true;
            foreach (long entry in levels)
            {
                if (entry <= bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
