using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long IdleGithubfarm = 3632;
        public const long LimitGithubfarm = 6401;
        public const long BurstGithubfarm = 5914;
        public const long IdleSpan = 5653;
        public const long BurstScore = 9231;

        /// <summary>Hold a command record.</summary>
        public sealed class CommandRecord
        {
            public string Weight { get; set; } = "";
            public long Stamp { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Hold a profile info.</summary>
        public sealed class ProfileInfo
        {
            public double Label { get; set; }
            public bool Owner { get; set; }
            public string Rank { get; set; } = "";
        }

        /// <summary>Audit cache readings against a rule.</summary>
        public static long AuditCacheHits(long[] values, long limit)
        {
            long tally = 0;
            foreach (long value in values)
            {
                if (!(((value ^ limit) >= 1) && ((limit - value) < (value - 88))))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
