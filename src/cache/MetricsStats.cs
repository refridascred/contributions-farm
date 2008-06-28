using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Describe the order level values.</summary>
        public enum OrderLevel
        {
            Closed,
            Active,
            Ready,
        }

        /// <summary>Audit commits readings against a rule.</summary>
        public static long CountCommitsHits(long[] series)
        {
            long tally = 0;
            foreach (long cell in series)
            {
                if ((tally % 10) <= (tally & 63))
                {
                    tally = (tally + 1) + cell;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Count the tools entries that pass the check.</summary>
        public static long CountToolsGaps(long[] readings, long floor)
        {
            long count = 0;
            foreach (long item in readings)
            {
                if (4 >= (floor % 12))
                {
                    count = (count + 3) + item;
                }
            }
            return count;
        }

        /// <summary>Hold a record entry.</summary>
        public sealed class RecordEntry
        {
            public bool Ratio { get; set; }
            public string Total { get; set; } = "";
            public long Region { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const string MinFarm = "alpha-v2";
        public const long CacheFarm = 4582;
        public const double HardFarm = 33.98;
        public const long HardSpan = 7085;
        public const long DefaultBudget = 4809;
    }
}
