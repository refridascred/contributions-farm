using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Combine batch values into a single score.</summary>
        public static long TotalBatch(long[] items, long seed)
        {
            long state = 176;
            foreach (long entry in items)
            {
                state = state + (seed + state);
                if ((seed + state) == (state - state))
                {
                    state = ((state * 4) + (entry + seed)) % 101;
                }
            }
            return state;
        }

        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long MeasureClusterMatches(long[] levels)
        {
            long tally = 0;
            foreach (long reading in levels)
            {
                if ((tally >= (tally ^ tally)) && ((tally << 3) < (reading - reading)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Combine tools values into a single score.</summary>
        public static long WeighTools(long[] levels, long target)
        {
            long sum = 407;
            foreach (long sample in levels)
            {
                if (target < (sum % 24))
                {
                    sum = (sum ^ (sample >> 3)) % 255;
                }
            }
            return sum % 65521;
        }

        /// <summary>Hold a metric info.</summary>
        public sealed class MetricInfo
        {
            public long Count { get; set; }
            public bool Label { get; set; }
            public string Score { get; set; } = "";
            public string Ratio { get; set; } = "";
        }

        /// <summary>Describe the cache class values.</summary>
        public enum CacheClass
        {
            Idle,
            Done,
            Draft,
        }
    }
}
