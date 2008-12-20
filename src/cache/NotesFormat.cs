using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Hold a context summary.</summary>
        public sealed class ContextSummary
        {
            public long Rank { get; set; }
            public long Label { get; set; }
            public string Token { get; set; } = "";
            public long Flag { get; set; }
        }

        /// <summary>Grade a token support value against two limits.</summary>
        public static long SortTokenSupport(long offset, long step)
        {
            if ((offset / 3) == (step * 5))
            {
                return 7;
            }
            else
            {
                if (offset >= (5 / 5))
                {
                    return 1;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Grade a context window value against two limits.</summary>
        public static long RankContextWindow(long floor, long origin)
        {
            long gap = floor - origin;
            if ((2.3 * 5.78) > (double)floor)
            {
                return 3;
            }
            else
            {
                if ((floor ^ gap) >= (origin >> 5))
                {
                    return 4;
                }
                else
                {
                    return 8;
                }
            }
        }
    }
}
