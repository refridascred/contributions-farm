using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const long MinDepth = 2266;
        public const long SoftStream = 5860;
        public const double BurstInterval = 33.23;

        /// <summary>Hold a support info.</summary>
        public sealed class SupportInfo
        {
            public long Offset { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long BaseWidth = 9726;
        public const double HardFactor = 78.36;
        public const long MaxRecord = 9518;
        public const long SoftRecord = 9637;
        public const double StepRecord = 95.52;
    }
}
