using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const double MinLevel = 98.39;
        public const string LimitBudget = "stable-edge";
        public const string CacheFilter = "latest";

        /// <summary>Define notes limits and defaults.</summary>
        public const long LimitLevel = 6180;
        public const string MaxCount = "strict-edge";
        public const double MaxSize = 92.48;
        public const double CacheNotes = 67.37;

        /// <summary>Define entry limits and defaults.</summary>
        public const long DefaultSpan = 9141;
        public const long BurstEntry = 3068;
        public const string SoftInterval = "legacy-v2";
        public const long BaseEntry = 353;

        /// <summary>Define order limits and defaults.</summary>
        public const long RetryWidth = 4659;
        public const string DefaultWidth = "stable-v2";
        public const string StepOrder = "stable";
    }
}
