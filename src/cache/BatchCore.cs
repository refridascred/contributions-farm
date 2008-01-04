using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Describe the profile class values.</summary>
        public enum ProfileClass
        {
            Pending,
            Closed,
            Idle,
            Paused,
            Failed,
        }

        /// <summary>Hold a buffer record.</summary>
        public sealed class BufferRecord
        {
            public long Limit { get; set; }
            public bool Owner { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const string StepFarm = "standard-edge";
        public const long BatchFarm = 6540;
        public const string LimitLevel = "alpha";
        public const double StepWidth = 27.63;

        /// <summary>Hold a payload options.</summary>
        public sealed class PayloadOptions
        {
            public long Flag { get; set; }
            public double Offset { get; set; }
            public double Size { get; set; }
        }
    }
}
