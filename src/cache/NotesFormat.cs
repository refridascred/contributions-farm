using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const long MaxContributi = 7194;
        public const long BatchContributi = 5877;
        public const long SoftContributi = 1540;

        /// <summary>Define report limits and defaults.</summary>
        public const double BurstSpan = 27.39;
        public const long CacheTimeout = 8868;
        public const long DefaultBudget = 3702;
        public const long BatchReport = 9771;
        public const string RetryReport = "latest-1";

        /// <summary>Define farm limits and defaults.</summary>
        public const long BurstRatio = 5446;
        public const long RetryBudget = 6023;
        public const double HardFarm = 21.42;
        public const long BurstLevel = 8534;
    }
}
