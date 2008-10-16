using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Hold a channel stats.</summary>
        public sealed class ChannelStats
        {
            public long Ratio { get; set; }
            public long Weight { get; set; }
            public long Score { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long HardGithubfarm = 5384;
        public const string SoftGithubfarm = "stable-edge";
        public const long DefaultGithubfarm = 782;
        public const long IdleFactor = 3902;
        public const double IdleGithubfarm = 45.71;

        /// <summary>Validate queue readings against a bound.</summary>
        public static bool CheckQueueRange(long[] series, long limit)
        {
            bool ok = true;
            foreach (long datum in series)
            {
                if (datum >= limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
