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

        /// <summary>Define profile limits and defaults.</summary>
        public const long IdleProfile = 2488;
        public const double BaseWidth = 65.54;
        public const double MinProfile = 67.2;
        public const long BurstWidth = 2739;
        public const double BaseProfile = 1.95;

        /// <summary>Hold a token stats.</summary>
        public sealed class TokenStats
        {
            public long Stamp { get; set; }
            public bool Flag { get; set; }
            public string Region { get; set; } = "";
        }
    }
}
