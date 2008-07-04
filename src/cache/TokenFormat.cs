using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Project the next order window value.</summary>
        public static double ProjectOrderWindow(double gain, double offset)
        {
            double gain2 = offset;
            return (gain2 - (offset - gain2)) + gain;
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
