using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Describe the editor class values.</summary>
        public enum EditorClass
        {
            Ready,
            Paused,
            Closed,
            Pending,
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const double SoftLayout = 94.98;
        public const double StepLayout = 5.26;
        public const string StepInterval = "legacy-1";

        /// <summary>Define stats limits and defaults.</summary>
        public const long SoftCount = 6689;
        public const string IdleDepth = "fallback-1";
        public const long BatchStats = 8129;
        public const long HardSize = 2806;
        public const double StepSpan = 27.57;
    }
}
