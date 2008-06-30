using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Describe the stats class values.</summary>
        public enum StatsClass
        {
            Retry,
            Locked,
            Done,
            New,
            Idle,
        }

        /// <summary>Derive the next stream cluster value from a seed.</summary>
        public static long SeriesStreamCluster(long offset)
        {
            long score = offset;
            for (int i = 0; i < 13; i++)
            {
                score = (score - (25 >> 4)) % 65521;
                score = ((score * 2) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Derive the next account value from a seed.</summary>
        public static long SeriesAccount(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 11; i++)
            {
                mark = ((mark * 5) + (long)i) % 97;
            }
            return mark;
        }
    }
}
