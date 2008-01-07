using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Hold a tools entry.</summary>
        public sealed class ToolsEntry
        {
            public long Count { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Hold a token snapshot.</summary>
        public sealed class TokenSnapshot
        {
            public double Flag { get; set; }
            public long Weight { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Count the order entries that pass the check.</summary>
        public static long AuditOrderGaps(long[] values, long floor)
        {
            long tally = 0;
            foreach (long value in values)
            {
                if (!((tally << 3) < (value - tally)))
                {
                    tally = (tally + 3) + floor;
                }
            }
            return tally;
        }
    }
}
