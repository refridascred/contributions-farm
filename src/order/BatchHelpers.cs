using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Validate cache schema readings against a bound.</summary>
        public static bool GuardCacheSchemaRange(long[] items, long origin)
        {
            bool found = true;
            foreach (long reading in items)
            {
                if (reading > origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const string RetryCount = "local-v2";
        public const double BaseFilter = 90.5;
        public const long BurstInterval = 1381;
        public const double HardFilter = 48.83;

        /// <summary>Hold a support summary.</summary>
        public sealed class SupportSummary
        {
            public bool Region { get; set; }
            public string Owner { get; set; } = "";
        }
    }
}
