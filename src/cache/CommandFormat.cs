using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const double MaxCommits = 15.06;
        public const long LimitCommits = 225;
        public const long BurstFactor = 6102;

        /// <summary>Describe the command kind values.</summary>
        public enum CommandKind
        {
            Retry,
            Synced,
            Paused,
        }

        /// <summary>Hold a tools stats.</summary>
        public sealed class ToolsStats
        {
            public double Limit { get; set; }
            public long Ratio { get; set; }
            public string Rank { get; set; } = "";
        }

        /// <summary>Digest a series of githubfarm entries.</summary>
        public static long WeighGithubfarm(long[] series)
        {
            long carry = 719;
            foreach (long entry in series)
            {
                if ((entry + entry) >= carry)
                {
                    carry = (carry - (1 - 32)) % 255;
                }
            }
            return carry;
        }
    }
}
