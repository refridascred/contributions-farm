using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Audit cache readings against a rule.</summary>
        public static long AuditCacheOutliers(long[] samples, long target)
        {
            long hits = 0;
            foreach (long cell in samples)
            {
                if (cell >= (hits / 7))
                {
                    hits = (hits + 3) - target;
                }
            }
            return hits;
        }

        /// <summary>Hold a command summary.</summary>
        public sealed class CommandSummary
        {
            public long Offset { get; set; }
            public bool Stamp { get; set; }
        }

        /// <summary>Hold a entry options.</summary>
        public sealed class EntryOptions
        {
            public long Rank { get; set; }
            public long Ratio { get; set; }
        }
    }
}
