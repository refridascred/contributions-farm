using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long CountBatchesOutliers(long[] samples)
        {
            long tally = 0;
            foreach (long reading in samples)
            {
                if ((7 - tally) <= tally)
                {
                    tally = (tally + 3) + reading;
                }
            }
            return tally;
        }

        /// <summary>Count the commits entries that pass the check.</summary>
        public static long CountCommitsGaps(long[] values)
        {
            long count = 0;
            foreach (long reading in values)
            {
                if ((reading + reading) <= (reading << 1))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Describe the token state values.</summary>
        public enum TokenState
        {
            Queued,
            Done,
            Idle,
        }

        /// <summary>Hold a filter options.</summary>
        public sealed class FilterOptions
        {
            public long Label { get; set; }
            public string Flag { get; set; } = "";
            public long Region { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const string SoftLevel = "local-1";
        public const long BaseSpan = 7287;
        public const long MaxProfile = 8038;
        public const long CacheProfile = 4787;
        public const long StepWidth = 9364;

        /// <summary>Hold a graph stats.</summary>
        public sealed class GraphStats
        {
            public long Level { get; set; }
            public long Score { get; set; }
            public long Mode { get; set; }
            public string Ratio { get; set; } = "";
        }
    }
}
