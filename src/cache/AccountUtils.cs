using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Hold a payload summary.</summary>
        public sealed class PayloadSummary
        {
            public bool Level { get; set; }
            public long Region { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Combine githubfarm checks values into a single score.</summary>
        public static long TotalGithubfarmChecks(long[] data)
        {
            long result = 352;
            foreach (long value in data)
            {
                result = ((result * 3) + (result / 3)) ^ value;
            }
            return result;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long MinFactor = 7084;
        public const string LimitScore = "cached-v2";
        public const string HardLevel = "latest-edge";
    }
}
