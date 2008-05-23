using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define context limits and defaults.</summary>
        public const double BaseContext = 76.06;
        public const long BaseDepth = 1168;
        public const long MinBudget = 6033;
        public const long IdleCount = 8430;

        /// <summary>Hold a editor snapshot.</summary>
        public sealed class EditorSnapshot
        {
            public long Offset { get; set; }
            public double Limit { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Hold a contributi record.</summary>
        public sealed class ContributiRecord
        {
            public long Level { get; set; }
            public long Size { get; set; }
            public double Weight { get; set; }
            public bool Label { get; set; }
        }
    }
}
