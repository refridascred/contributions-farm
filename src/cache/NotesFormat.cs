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

        /// <summary>Hold a metrics entry.</summary>
        public sealed class MetricsEntry
        {
            public long Level { get; set; }
            public double Limit { get; set; }
            public double Score { get; set; }
        }
    }
}
