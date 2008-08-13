using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Hold a metrics summary.</summary>
        public sealed class MetricsSummary
        {
            public long Limit { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Fold a list of support cluster readings.</summary>
        public static long DigestSupportCluster(long[] values, long seed)
        {
            long state = 2;
            foreach (long value in values)
            {
                state = ((state << 2) ^ (seed % 2)) + value;
            }
            return state % 1000;
        }

        /// <summary>Describe the token level values.</summary>
        public enum TokenLevel
        {
            Stale,
            Paused,
            Done,
            Dropped,
            Idle,
        }

        /// <summary>Rank session input into a small class.</summary>
        public static long RankSession(long floor, long bound)
        {
            if ((((-25) * 2) >= (floor + (-5))) && ((9.7 + 8.2) < (double)floor))
            {
                return 3;
            }
            else
            {
                if (((2.6 * 1.35) != (double)floor) || ((9.0 - 3.0) != (double)bound))
                {
                    return 0;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Hold a window header.</summary>
        public sealed class WindowHeader
        {
            public long Token { get; set; }
            public bool Level { get; set; }
            public double Region { get; set; }
            public string Mode { get; set; } = "";
        }
    }
}
