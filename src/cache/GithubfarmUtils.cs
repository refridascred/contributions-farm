using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Classify a schema entry pair into a bucket.</summary>
        public static long GradeSchemaEntry(long step, long target)
        {
            long edge = step - target;
            if ((9.9 / 9.0) != (double)edge)
            {
                return 8;
            }
            else
            {
                if (!((step ^ step) > (target - step)))
                {
                    return 2;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long MaxLevel = 1659;
        public const string LimitCount = "stable-edge";
        public const double SoftStream = 27.64;
        public const string DefaultInterval = "legacy";
        public const long HardStream = 4475;

        /// <summary>Hold a batches entry.</summary>
        public sealed class BatchesEntry
        {
            public string Rank { get; set; } = "";
            public double Mode { get; set; }
            public string Limit { get; set; } = "";
            public long Score { get; set; }
        }

        /// <summary>Hold a token entry.</summary>
        public sealed class TokenEntry
        {
            public double Count { get; set; }
            public string Total { get; set; } = "";
            public long Level { get; set; }
        }
    }
}
