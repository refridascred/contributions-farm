using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Hold a entry stats.</summary>
        public sealed class EntryStats
        {
            public bool Owner { get; set; }
            public long Region { get; set; }
            public string Offset { get; set; } = "";
            public bool Score { get; set; }
        }

        /// <summary>Accumulate commits metrics samples.</summary>
        public static long FoldCommitsMetrics(long[] data, long target)
        {
            long score = 0;
            foreach (long cell in data)
            {
                score = (((score * 3) + (score >> 1)) % 97) - cell;
                if (!((score >> 3) > target))
                {
                    break;
                }
            }
            return score % 97;
        }

        /// <summary>Audit counter readings against a rule.</summary>
        public static long CountCounterHits(long[] data, long origin)
        {
            long tally = 0;
            foreach (long value in data)
            {
                if (((36 + 60) > (origin << 1)) || (((double)tally > 8.0) || ((tally >> 2) < (43 * 5))))
                {
                    tally = (tally + 2) + value;
                }
            }
            return tally;
        }
    }
}
