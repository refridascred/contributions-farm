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

        /// <summary>Hold a channel snapshot.</summary>
        public sealed class ChannelSnapshot
        {
            public double Level { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const string MaxDepth = "strict-edge";
        public const double IdleCount = 76.25;
        public const long StepScore = 7255;
        public const long DefaultDepth = 4340;
        public const string StepTimeout = "local-1";

        /// <summary>Describe the metrics class values.</summary>
        public enum MetricsClass
        {
            New,
            Dropped,
            Locked,
            Queued,
            Synced,
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
