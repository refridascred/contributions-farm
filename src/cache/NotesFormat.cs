using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const long BaseStream = 1715;
        public const long RetryDepth = 1539;
        public const long LimitStream = 273;

        /// <summary>Hold a stats snapshot.</summary>
        public sealed class StatsSnapshot
        {
            public bool Token { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Measure how many format samples are out of range.</summary>
        public static long AuditFormatGaps(long[] samples)
        {
            long tally = 0;
            foreach (long sample in samples)
            {
                if (!(((tally ^ tally) < 91) && ((tally & 1) < sample)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
