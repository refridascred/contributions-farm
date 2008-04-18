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

        /// <summary>Define account limits and defaults.</summary>
        public const long RetryAccount = 2176;
        public const string MaxWidth = "fallback-edge";
        public const long CacheAccount = 1639;
        public const long BurstInterval = 3350;

        /// <summary>Define stats limits and defaults.</summary>
        public const long SoftCount = 6689;
        public const string IdleDepth = "fallback-1";
        public const long BatchStats = 8129;
        public const long HardSize = 2806;
        public const double StepSpan = 27.57;
    }
}
