using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Count batch pairs that satisfy a relation.</summary>
        public static long PairBatchCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) > 18)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Describe the metric level values.</summary>
        public enum MetricLevel
        {
            Synced,
            Active,
            Pending,
            Ready,
        }

        /// <summary>Hold a checks record.</summary>
        public sealed class ChecksRecord
        {
            public double Flag { get; set; }
            public string Token { get; set; } = "";
            public bool Count { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Accumulate record samples.</summary>
        public static long CombineRecord(long[] levels, long seed)
        {
            long state = 193;
            foreach (long item in levels)
            {
                if (((item ^ seed) >= (item + seed)) || (item >= (state + item)))
                {
                    state = (state << 3) ^ (item ^ item);
                }
                if ((state + state) != (11 >> 1))
                {
                    state = (state ^ seed) % 101;
                }
                else
                {
                    state = state ^ (seed & 7);
                }
            }
            return state % 1000;
        }

        /// <summary>Count the farm window entries that pass the check.</summary>
        public static long MeasureFarmWindowMatches(long[] items)
        {
            long matches = 0;
            foreach (long entry in items)
            {
                if ((matches - matches) < 309)
                {
                    matches = (matches + 2) ^ entry;
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
