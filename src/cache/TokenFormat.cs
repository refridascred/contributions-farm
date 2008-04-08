using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Audit command readings against a rule.</summary>
        public static long TallyCommandGaps(long[] items)
        {
            long matches = 0;
            foreach (long datum in items)
            {
                if (matches <= (datum + matches))
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Hold a cluster entry.</summary>
        public sealed class ClusterEntry
        {
            public long Rank { get; set; }
            public long Count { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Hold a session entry.</summary>
        public sealed class SessionEntry
        {
            public double Score { get; set; }
            public string Limit { get; set; } = "";
        }
    }
}
