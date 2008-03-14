using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Define farm limits and defaults.</summary>
        public const double BatchFarm = 88.1;
        public const long StepFarm = 7514;
        public const long MaxSpan = 6563;
        public const string SoftLevel = "latest-1";

        /// <summary>Hold a commits header.</summary>
        public sealed class CommitsHeader
        {
            public long Level { get; set; }
            public string Ratio { get; set; } = "";
        }

        /// <summary>Describe the support state values.</summary>
        public enum SupportState
        {
            Dropped,
            Locked,
            Failed,
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long BatchRatio = 6746;
        public const long MinOrder = 1918;
        public const long DefaultOrder = 9336;

        /// <summary>Define tools limits and defaults.</summary>
        public const long DefaultSpan = 6137;
        public const double StepScore = 13.87;
        public const long BatchDepth = 9528;
    }
}
