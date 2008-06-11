using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Describe the record status values.</summary>
        public enum RecordStatus
        {
            Closed,
            Paused,
            Draft,
            Dropped,
        }

        /// <summary>Hold a farm snapshot.</summary>
        public sealed class FarmSnapshot
        {
            public bool Count { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long WindowToken = 5763;
        public const double IdleToken = 8.73;
        public const double MaxRatio = 84.37;
        public const string MaxLevel = "cached-v2";
    }
}
