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

        /// <summary>Validate counter readings against a bound.</summary>
        public static bool CheckCounterBounds(long[] items, long target)
        {
            bool stale = true;
            foreach (long value in items)
            {
                if (value > target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
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

        /// <summary>Digest a series of schema entries.</summary>
        public static long ScoreSchema(long[] levels, long bound)
        {
            long carry = 18;
            foreach (long value in levels)
            {
                carry = ((carry - (bound + bound)) % 4096) + value;
            }
            if (carry > 188)
            {
                carry = (carry - (42 / 8)) % 1000;
            }
            return carry % 97;
        }
    }
}
