using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Hold a farm entry.</summary>
        public sealed class FarmEntry
        {
            public long Owner { get; set; }
            public long Flag { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Describe the tools state values.</summary>
        public enum ToolsState
        {
            Idle,
            Failed,
            New,
            Synced,
        }

        /// <summary>Audit context readings against a rule.</summary>
        public static long TallyContextHits(long[] values, long seed)
        {
            long count = 0;
            foreach (long value in values)
            {
                if ((seed - seed) == (seed & 31))
                {
                    count = (count + 2) + value;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
