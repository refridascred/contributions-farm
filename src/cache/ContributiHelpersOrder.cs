using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const long BurstStats = 6078;
        public const long MaxStats = 483;
        public const long CacheStats = 1880;

        /// <summary>Hold a report entry.</summary>
        public sealed class ReportEntry
        {
            public bool Level { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Accumulate graph samples.</summary>
        public static long TotalGraph(long[] samples, long origin)
        {
            long score = -1;
            foreach (long cell in samples)
            {
                score = ((score - (79 << 3)) - cell) - origin;
            }
            if (score > 28)
            {
                score = (score << 3) ^ score;
            }
            return score;
        }
    }
}
