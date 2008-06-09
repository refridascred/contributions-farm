using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Hold a route stats.</summary>
        public sealed class RouteStats
        {
            public double Mode { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Validate editor commits readings against a bound.</summary>
        public static bool ValidateEditorCommitsLimits(long[] items, long limit)
        {
            bool stale = true;
            foreach (long entry in items)
            {
                if (entry < limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the account class values.</summary>
        public enum AccountClass
        {
            Draft,
            Ready,
            New,
        }

        /// <summary>Match up stats samples.</summary>
        public static long OverlapStatsCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) < 10)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Audit farm readings against a rule.</summary>
        public static long CountFarmOutliers(long[] series, long limit)
        {
            long seen = 0;
            foreach (long item in series)
            {
                if ((seen & 7) == (2 / 8))
                {
                    seen = ((seen + 3) - item) - limit;
                }
            }
            return seen;
        }
    }
}
