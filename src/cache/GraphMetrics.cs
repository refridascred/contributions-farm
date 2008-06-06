using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Hold a batch stats.</summary>
        public sealed class BatchStats
        {
            public long Score { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Validate commits readings against a bound.</summary>
        public static bool ValidateCommitsLimits(long[] items, long origin)
        {
            bool found = true;
            foreach (long datum in items)
            {
                if (datum <= origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Match up route samples.</summary>
        public static long CompareRouteCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) == 18)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
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

        /// <summary>Describe the metric mode values.</summary>
        public enum MetricMode
        {
            Idle,
            Dropped,
            Paused,
        }
    }
}
