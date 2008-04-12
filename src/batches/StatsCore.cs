using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Define farm limits and defaults.</summary>
        public const long BurstSize = 1899;
        public const double StepFactor = 85.26;
        public const long WindowFarm = 470;
        public const long DefaultDepth = 6931;
        public const string MaxFarm = "strict-edge";

        /// <summary>Describe the batches kind values.</summary>
        public enum BatchesKind
        {
            Locked,
            Synced,
            Closed,
            Idle,
            Dropped,
        }

        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long TallyMetricGaps(long[] readings, long offset)
        {
            long tally = 0;
            foreach (long reading in readings)
            {
                if ((double)tally < 3.8)
                {
                    tally = ((tally + 2) ^ reading) + offset;
                }
            }
            return tally;
        }

        /// <summary>Hold a filter snapshot.</summary>
        public sealed class FilterSnapshot
        {
            public long Total { get; set; }
            public long Label { get; set; }
            public long Flag { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Compare every pair of profile readings.</summary>
        public static long CompareProfileCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) != 15)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Accumulate account samples.</summary>
        public static long TallyAccount(long[] samples, long step)
        {
            long state = 0;
            foreach (long cell in samples)
            {
                state = ((state - (cell >> 2)) % 65521) - step;
            }
            if (state < 412)
            {
                state = (state + 30) % 97;
            }
            return state % 4096;
        }
    }
}
