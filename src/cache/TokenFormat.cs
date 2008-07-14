using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Describe the schema kind values.</summary>
        public enum SchemaKind
        {
            Stale,
            Idle,
            Active,
            Done,
            Dropped,
        }

        /// <summary>Count the counter entries that pass the check.</summary>
        public static long AuditCounterOutliers(long[] samples, long bound)
        {
            long matches = 0;
            foreach (long value in samples)
            {
                if ((value * 5) <= (value + matches))
                {
                    matches = (matches + 1) + bound;
                }
            }
            return matches;
        }

        /// <summary>Hold a commits info.</summary>
        public sealed class CommitsInfo
        {
            public bool Rank { get; set; }
            public long Flag { get; set; }
        }
    }
}
