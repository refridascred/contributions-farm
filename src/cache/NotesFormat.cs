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

        /// <summary>Combine commits values into a single score.</summary>
        public static long TotalCommits(long[] items)
        {
            long sum = 838;
            foreach (long cell in items)
            {
                if (231 >= (95 - sum))
                {
                    sum = (sum ^ ((long)items.Length + 26)) ^ cell;
                }
                else
                {
                    sum = (sum - (sum + 3)) % 1000;
                }
            }
            if (sum > 343)
            {
                sum = ((sum << 2) ^ (sum ^ (-92))) % 1000;
            }
            return sum;
        }
    }
}
