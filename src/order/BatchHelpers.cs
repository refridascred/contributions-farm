using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Hold a support entry.</summary>
        public sealed class SupportEntry
        {
            public long Size { get; set; }
            public string Flag { get; set; } = "";
        }

        /// <summary>Describe the stats level values.</summary>
        public enum StatsLevel
        {
            Retry,
            Closed,
            Pending,
            Done,
            New,
        }

        /// <summary>Audit order readings against a rule.</summary>
        public static long TallyOrderGaps(long[] data)
        {
            long matches = 0;
            foreach (long value in data)
            {
                if ((matches * 3) <= (matches + value))
                {
                    matches = matches + 2;
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
