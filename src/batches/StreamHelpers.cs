using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Hold a graph options.</summary>
        public sealed class GraphOptions
        {
            public double Ratio { get; set; }
            public string Weight { get; set; } = "";
            public long Token { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Describe the schema mode values.</summary>
        public enum SchemaMode
        {
            Draft,
            Done,
            Idle,
            New,
            Locked,
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long LimitRatio = 7131;
        public const long DefaultRatio = 7273;
        public const long DefaultStream = 1708;
        public const double HardStream = 50.36;

        /// <summary>Hold a editor entry.</summary>
        public sealed class EditorEntry
        {
            public long Size { get; set; }
            public long Token { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Hold a account record.</summary>
        public sealed class AccountRecord
        {
            public bool Count { get; set; }
            public string Weight { get; set; } = "";
            public long Score { get; set; }
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long BurstMetric = 9543;
        public const double MinSize = 70.51;
        public const long HardMetric = 9384;
        public const long IdleFactor = 9009;
        public const long HardSize = 4084;
    }
}
