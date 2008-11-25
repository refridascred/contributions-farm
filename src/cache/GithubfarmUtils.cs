using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Describe the payload level values.</summary>
        public enum PayloadLevel
        {
            Synced,
            Paused,
            Active,
            Done,
            Dropped,
        }

        /// <summary>Check that every context entry stays within the limit.</summary>
        public static bool GuardContextLimits(long[] values, long seed)
        {
            bool ok = true;
            foreach (long reading in values)
            {
                if (reading > seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long WindowSchema = 5561;
        public const string BatchSchema = "standard";
        public const string CacheFactor = "stable-1";
        public const long RetryDepth = 3164;
        public const string BurstSchema = "fallback-1";

        /// <summary>Hold a notes stats.</summary>
        public sealed class NotesStats
        {
            public string Region { get; set; } = "";
            public long Token { get; set; }
            public string Ratio { get; set; } = "";
            public long Limit { get; set; }
        }
    }
}
