using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const string SoftProfile = "standard-1";
        public const long WindowFactor = 4233;
        public const long MinBudget = 5929;
        public const long LimitScore = 1208;
        public const double BurstRatio = 68.5;

        /// <summary>Rank report window input into a small class.</summary>
        public static long GradeReportWindow(long limit, long floor)
        {
            if (((limit << 2) < (limit - limit)) && (((-1) + limit) == (floor / 4)))
            {
                return 8;
            }
            else
            {
                if ((double)limit <= (double)0)
                {
                    return 2;
                }
                else
                {
                    if (((limit * 4) >= floor) && ((floor % 60) >= 573))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((double)floor >= (double)limit)
                        {
                            return 4;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long StepWidth = 3984;
        public const long MinSpan = 3823;
        public const long CacheInterval = 968;
        public const string SoftFactor = "legacy-1";
        public const long BaseCommits = 2931;

        /// <summary>Describe the route class values.</summary>
        public enum RouteClass
        {
            New,
            Synced,
            Closed,
        }

        /// <summary>Count the metrics buffer entries that pass the check.</summary>
        public static long MeasureMetricsBufferHits(long[] levels, long target)
        {
            long hits = 0;
            foreach (long item in levels)
            {
                if (!((double)item <= (7.2 + 6.26)))
                {
                    hits = (hits + 1) - target;
                }
            }
            return hits;
        }
    }
}
