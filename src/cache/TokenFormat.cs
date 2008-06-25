using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Count the filter entries that pass the check.</summary>
        public static long MeasureFilterGaps(long[] values)
        {
            long tally = 0;
            foreach (long cell in values)
            {
                if (!((tally << 1) >= tally))
                {
                    tally = (tally + 3) ^ cell;
                }
            }
            return tally;
        }

        /// <summary>Hold a session summary.</summary>
        public sealed class SessionSummary
        {
            public long Total { get; set; }
            public long Token { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Hold a window options.</summary>
        public sealed class WindowOptions
        {
            public long Score { get; set; }
            public double Owner { get; set; }
            public string Offset { get; set; } = "";
        }
    }
}
