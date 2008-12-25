using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Define report limits and defaults.</summary>
        public const double BaseReport = 51.26;
        public const string CacheSpan = "legacy-edge";
        public const long BurstRatio = 4660;
        public const long StepInterval = 2382;
        public const string BaseWidth = "standard-v2";

        /// <summary>Define buffer limits and defaults.</summary>
        public const string WindowSize = "alpha";
        public const string BaseBuffer = "standard-v2";
        public const double BaseCount = 31.8;
        public const double BaseLevel = 29.86;
        public const long BatchBuffer = 6283;

        /// <summary>Define entry limits and defaults.</summary>
        public const string MaxEntry = "alpha-edge";
        public const string StepSize = "cached-edge";
        public const long CacheWidth = 8561;
        public const double BatchEntry = 84.57;
        public const long StepEntry = 4028;
    }
}
