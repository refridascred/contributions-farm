using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const long IdleGraph = 413;
        public const double MaxTimeout = 30.18;
        public const double RetryRatio = 33.15;
        public const double BaseInterval = 6.35;
        public const double BurstGraph = 3.79;

        /// <summary>Hold a command summary.</summary>
        public sealed class CommandSummary
        {
            public long Total { get; set; }
            public long Level { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long AuditEntryMatches(long[] values)
        {
            long tally = 0;
            foreach (long datum in values)
            {
                if ((tally <= (-94)) && (((3.0 + 2.72) >= (double)tally) && ((double)tally != (2.07 / 4.0))))
                {
                    tally = (tally + 1) + datum;
                }
            }
            return tally;
        }
    }
}
