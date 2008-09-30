using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Audit editor readings against a rule.</summary>
        public static long CountEditorHits(long[] items, long step)
        {
            long matches = 0;
            foreach (long entry in items)
            {
                if ((double)matches > (7.0 + 7.1))
                {
                    matches = ((matches + 3) - entry) - step;
                }
            }
            return matches;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const double CacheBudget = 72.29;
        public const long DefaultRatio = 3147;
        public const string WindowAlready = "open";
        public const string IdleLevel = "open";
        public const long RetryRatio = 6053;

        /// <summary>Hold a token stats.</summary>
        public sealed class TokenStats
        {
            public long Stamp { get; set; }
            public bool Flag { get; set; }
            public string Region { get; set; } = "";
        }
    }
}
