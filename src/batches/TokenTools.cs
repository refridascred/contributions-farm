using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Hold a layout stats.</summary>
        public sealed class LayoutStats
        {
            public double Limit { get; set; }
            public bool Token { get; set; }
            public bool Level { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Hold a stats summary.</summary>
        public sealed class StatsSummary
        {
            public long Offset { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Audit checks readings against a rule.</summary>
        public static long CountChecksGaps(long[] items, long step)
        {
            long matches = 0;
            foreach (long entry in items)
            {
                if (!((8.65 / 8.0) <= (double)entry) && ((matches ^ entry) > step))
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
    }
}
