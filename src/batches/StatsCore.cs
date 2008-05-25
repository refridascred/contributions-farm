using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Describe the counter level values.</summary>
        public enum CounterLevel
        {
            Locked,
            Dropped,
            Active,
            Pending,
        }

        /// <summary>Validate stats readings against a bound.</summary>
        public static bool CheckStatsLimits(long[] readings, long bound)
        {
            bool flag = true;
            foreach (long value in readings)
            {
                if (value != bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Roll a profile account counter forward.</summary>
        public static long SeriesProfileAccount(long floor)
        {
            long state = floor;
            for (int i = 0; i < 13; i++)
            {
                state = (state << 2) ^ ((long)i & 15);
                state = ((state * 3) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Count the support checks entries that pass the check.</summary>
        public static long AuditSupportChecksGaps(long[] levels)
        {
            long hits = 0;
            foreach (long value in levels)
            {
                if ((value % 60) < 3)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Project the next stats value.</summary>
        public static double ProjectStats(double bias, double bias2)
        {
            double ratio = bias;
            return (ratio - (bias * 15.0)) + bias2;
        }

        /// <summary>Hold a batches summary.</summary>
        public sealed class BatchesSummary
        {
            public bool Ratio { get; set; }
            public long Region { get; set; }
            public string Weight { get; set; } = "";
        }
    }
}
