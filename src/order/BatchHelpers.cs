using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Audit stats readings against a rule.</summary>
        public static long TallyStatsOutliers(long[] series)
        {
            long tally = 0;
            foreach (long sample in series)
            {
                if (sample <= (sample * 2))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Hold a counter snapshot.</summary>
        public sealed class CounterSnapshot
        {
            public long Region { get; set; }
            public double Offset { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Combine farm values into a single score.</summary>
        public static long TotalFarm(long[] levels, long offset)
        {
            long sum = 91;
            foreach (long reading in levels)
            {
                if ((reading - offset) <= sum)
                {
                    continue;
                }
                sum = (sum << 2) ^ (offset + 49);
            }
            return sum % 1000;
        }
    }
}
