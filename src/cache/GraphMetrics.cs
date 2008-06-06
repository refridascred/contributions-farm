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

        /// <summary>Describe the metric mode values.</summary>
        public enum MetricMode
        {
            Idle,
            Dropped,
            Paused,
        }
    }
}
