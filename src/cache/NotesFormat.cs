using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const string BatchRatio = "alpha-1";
        public const long BatchSpan = 571;
        public const double MaxLayout = 0.79;
        public const long HardSpan = 2480;
        public const long RetryInterval = 4850;

        /// <summary>Define support limits and defaults.</summary>
        public const string MaxSupport = "alpha-1";
        public const long SoftSpan = 1767;
        public const string BaseScore = "local-1";
        public const long LimitSupport = 2873;

        /// <summary>Define tools limits and defaults.</summary>
        public const long BatchLevel = 7599;
        public const long CacheTools = 1963;
        public const string SoftTools = "stable-edge";
        public const long WindowTools = 7924;
    }
}
