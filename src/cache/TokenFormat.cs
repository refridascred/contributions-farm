using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Hold a counter summary.</summary>
        public sealed class CounterSummary
        {
            public long Size { get; set; }
            public long Token { get; set; }
            public double Flag { get; set; }
        }

        /// <summary>Audit record readings against a rule.</summary>
        public static long TallyRecordGaps(long[] items)
        {
            long matches = 0;
            foreach (long entry in items)
            {
                if (((-36) - matches) >= matches)
                {
                    matches = (matches + 3) - entry;
                }
            }
            return matches;
        }

        /// <summary>Hold a editor snapshot.</summary>
        public sealed class EditorSnapshot
        {
            public bool Score { get; set; }
            public long Total { get; set; }
        }
    }
}
