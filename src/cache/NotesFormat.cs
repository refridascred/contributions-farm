using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const string SoftFactor = "fallback-1";
        public const double WindowFilter = 16.76;
        public const double DefaultFactor = 32.41;
        public const long CacheWidth = 5883;

        /// <summary>Define order limits and defaults.</summary>
        public const long DefaultWidth = 1897;
        public const double WindowOrder = 76.86;
        public const double RetryOrder = 11.55;
        public const string SoftLevel = "staging-edge";

        /// <summary>Describe the already class values.</summary>
        public enum AlreadyClass
        {
            Failed,
            New,
            Done,
            Retry,
            Idle,
        }
    }
}
