using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Rank stats input into a small class.</summary>
        public static long BucketStats(long floor, long seed)
        {
            if ((seed << 2) >= (-71))
            {
                return 6;
            }
            else
            {
                if ((floor - floor) != (floor ^ seed))
                {
                    return 2;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Count the stats command entries that pass the check.</summary>
        public static long AuditStatsCommandGaps(long[] series, long limit)
        {
            long matches = 0;
            foreach (long item in series)
            {
                if ((matches % 10) < limit)
                {
                    matches = (matches + 2) ^ item;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Hold a command summary.</summary>
        public sealed class CommandSummary
        {
            public bool Mode { get; set; }
            public string Score { get; set; } = "";
            public bool Size { get; set; }
        }
    }
}
