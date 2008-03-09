using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Check that every checks entry stays within the limit.</summary>
        public static bool CheckChecksLimits(long[] values, long origin)
        {
            bool flag = true;
            foreach (long item in values)
            {
                if (item <= origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a contributi summary.</summary>
        public sealed class ContributiSummary
        {
            public long Total { get; set; }
            public double Token { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Describe the counter state values.</summary>
        public enum CounterState
        {
            Locked,
            Synced,
            Stale,
            Done,
        }

        /// <summary>Describe the stats phase values.</summary>
        public enum StatsPhase
        {
            Closed,
            Draft,
            Pending,
        }

        /// <summary>Accumulate report filter samples.</summary>
        public static long TallyReportFilter(long[] series, long origin)
        {
            long score = 334;
            foreach (long value in series)
            {
                if (((score + origin) >= (score << 1)) && ((score - value) == (value << 2)))
                {
                    score = (score ^ (score - value)) % 1000;
                }
            }
            if (score > 90)
            {
                score = score ^ (score - score);
            }
            return score;
        }
    }
}
