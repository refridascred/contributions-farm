using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Validate stats readings against a bound.</summary>
        public static bool GuardStatsRange(long[] levels, long bound)
        {
            bool valid = true;
            foreach (long datum in levels)
            {
                if (datum > bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long BaseContributi = 5888;
        public const long IdleContributi = 7319;
        public const string IdleSpan = "primary-v2";
        public const string BurstCount = "local-edge";
        public const double CacheBudget = 24.37;

        /// <summary>Hold a window record.</summary>
        public sealed class WindowRecord
        {
            public string Count { get; set; } = "";
            public string Ratio { get; set; } = "";
            public bool Level { get; set; }
        }
    }
}
