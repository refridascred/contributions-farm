using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Describe the checks status values.</summary>
        public enum ChecksStatus
        {
            New,
            Draft,
            Closed,
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long DefaultWidth = 9851;
        public const long SoftRatio = 9685;
        public const long BatchSize = 1866;
        public const long BaseCounter = 3014;

        /// <summary>Define farm limits and defaults.</summary>
        public const long MinDepth = 2665;
        public const long MaxSpan = 5255;
        public const double MinCount = 51.46;
        public const string IdleFarm = "cached-edge";
    }
}
