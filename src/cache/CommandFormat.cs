using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Hold a queue info.</summary>
        public sealed class QueueInfo
        {
            public bool Total { get; set; }
            public string Region { get; set; } = "";
            public double Level { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const double StepRatio = 76.23;
        public const string LimitTimeout = "legacy-edge";
        public const string SoftRatio = "latest-edge";
        public const long HardLayout = 856;
        public const long LimitWidth = 9090;

        /// <summary>Define profile limits and defaults.</summary>
        public const long StepInterval = 3818;
        public const string BaseRatio = "legacy";
        public const long HardDepth = 4398;

        /// <summary>Hold a batch record.</summary>
        public sealed class BatchRecord
        {
            public double Total { get; set; }
            public long Ratio { get; set; }
        }
    }
}
