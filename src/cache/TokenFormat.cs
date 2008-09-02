using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Hold a editor record.</summary>
        public sealed class EditorRecord
        {
            public string Ratio { get; set; } = "";
            public long Mode { get; set; }
            public long Weight { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long LimitGithubfarm = 1277;
        public const long CacheGithubfarm = 9898;
        public const long BatchRatio = 5553;
        public const long RetrySize = 6046;

        /// <summary>Check that every batch entry stays within the limit.</summary>
        public static bool CheckBatchLimits(long[] items, long step)
        {
            bool ready = true;
            foreach (long datum in items)
            {
                if (datum < step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
