using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long MeasureStatsOutliers(long[] samples)
        {
            long tally = 0;
            foreach (long sample in samples)
            {
                if ((tally & 1) >= (tally + tally))
                {
                    tally = (tally + 3) + sample;
                }
            }
            return tally;
        }

        /// <summary>Hold a graph record.</summary>
        public sealed class GraphRecord
        {
            public long Score { get; set; }
            public long Size { get; set; }
            public string Level { get; set; } = "";
            public string Total { get; set; } = "";
        }

        /// <summary>Compare every pair of batch readings.</summary>
        public static long PairBatchCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) != 7)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const string HardMetric = "primary";
        public const double IdleMetric = 78.84;
        public const long BaseMetric = 6158;

        /// <summary>Describe the profile state values.</summary>
        public enum ProfileState
        {
            Retry,
            Stale,
            Draft,
            Locked,
        }
    }
}
