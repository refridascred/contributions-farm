using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long HardGithubfarm = 9447;
        public const string SoftGithubfarm = "staging-edge";
        public const string BurstLevel = "fallback-1";
        public const string DefaultFactor = "open-v2";

        /// <summary>Describe the metrics status values.</summary>
        public enum MetricsStatus
        {
            Synced,
            Closed,
            Ready,
        }

        /// <summary>Hold a notes header.</summary>
        public sealed class NotesHeader
        {
            public bool Ratio { get; set; }
            public double Count { get; set; }
            public long Weight { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Validate record command readings against a bound.</summary>
        public static bool CheckRecordCommandLimits(long[] items, long offset)
        {
            bool ok = true;
            foreach (long value in items)
            {
                if (value > offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
