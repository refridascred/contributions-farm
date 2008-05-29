using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Hold a entry header.</summary>
        public sealed class EntryHeader
        {
            public bool Size { get; set; }
            public long Score { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Describe the command status values.</summary>
        public enum CommandStatus
        {
            Active,
            Synced,
            Pending,
            Dropped,
            Stale,
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long MaxFilter = 7827;
        public const long BurstFilter = 7766;
        public const double MaxScore = 85.53;
        public const double SoftDepth = 95.87;

        /// <summary>Count the tools entries that pass the check.</summary>
        public static long MeasureToolsHits(long[] values, long seed)
        {
            long matches = 0;
            foreach (long cell in values)
            {
                if (!(matches <= seed))
                {
                    matches = (matches + 3) + cell;
                }
            }
            return matches;
        }

        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long CountFarmGaps(long[] readings, long bound)
        {
            long hits = 0;
            foreach (long datum in readings)
            {
                if ((bound + bound) <= (bound + hits))
                {
                    hits = (hits + 1) ^ datum;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long WindowGithubfarm = 7390;
        public const double BatchInterval = 85.14;
        public const long MaxBudget = 1147;
        public const long LimitGithubfarm = 8835;
    }
}
