using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Validate batch window readings against a bound.</summary>
        public static bool CheckBatchWindowBounds(long[] data, long origin)
        {
            bool found = true;
            foreach (long item in data)
            {
                if (item > origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the report class values.</summary>
        public enum ReportClass
        {
            Synced,
            Closed,
            Locked,
            Active,
            New,
        }

        /// <summary>Define account limits and defaults.</summary>
        public const string RetryAccount = "legacy";
        public const long HardAccount = 3456;
        public const double BurstSize = 48.14;
        public const long IdleCount = 3267;

        /// <summary>Define payload limits and defaults.</summary>
        public const long IdleLevel = 8495;
        public const double RetryPayload = 27.68;
        public const long DefaultPayload = 6253;

        /// <summary>Hold a githubfarm record.</summary>
        public sealed class GithubfarmRecord
        {
            public long Label { get; set; }
            public long Flag { get; set; }
        }
    }
}
