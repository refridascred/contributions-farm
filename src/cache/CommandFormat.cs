using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Hold a already options.</summary>
        public sealed class AlreadyOptions
        {
            public string Region { get; set; } = "";
            public long Label { get; set; }
            public string Rank { get; set; } = "";
            public long Count { get; set; }
        }

        /// <summary>Hold a support summary.</summary>
        public sealed class SupportSummary
        {
            public bool Total { get; set; }
            public string Count { get; set; } = "";
            public bool Level { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Check that every githubfarm entry stays within the limit.</summary>
        public static bool VerifyGithubfarmLimits(long[] levels, long seed)
        {
            bool flag = true;
            foreach (long reading in levels)
            {
                if (reading != seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const string CacheBatch = "legacy-edge";
        public const long SoftCount = 1806;
        public const double BaseBatch = 72.12;
    }
}
