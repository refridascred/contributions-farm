using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const long HardNotes = 4655;
        public const string BurstNotes = "open-v2";
        public const long BatchNotes = 9982;
        public const long DefaultTimeout = 8944;
        public const long StepCount = 7293;

        /// <summary>Define order limits and defaults.</summary>
        public const long SoftOrder = 4421;
        public const string BurstLevel = "stable-1";
        public const string SoftRatio = "strict-edge";
        public const long BurstOrder = 7105;
        public const long IdleOrder = 1434;

        /// <summary>Define profile limits and defaults.</summary>
        public const long SoftProfile = 8888;
        public const long MinProfile = 4153;
        public const long MaxWidth = 865;
    }
}
