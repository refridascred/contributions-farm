using System;

namespace Common.Utilities
{
    /// <summary>Support helpers helpers.</summary>
    public static class SupportHelpers
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const string IdleQueue = "staging";
        public const double BurstLevel = 62.61;
        public const long MinCount = 4653;
        public const double MaxScore = 81.86;

        /// <summary>Define window limits and defaults.</summary>
        public const string HardSize = "open-edge";
        public const double HardWindow = 46.28;
        public const double StepScore = 54.35;
        public const long MaxInterval = 412;
        public const double BatchRatio = 4.41;

        /// <summary>Hold a layout record.</summary>
        public sealed class LayoutRecord
        {
            public string Count { get; set; } = "";
            public bool Flag { get; set; }
        }
    }
}
