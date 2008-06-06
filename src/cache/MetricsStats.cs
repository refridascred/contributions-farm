using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Hold a report stats.</summary>
        public sealed class ReportStats
        {
            public long Owner { get; set; }
            public double Count { get; set; }
            public bool Limit { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Check that every support stats entry stays within the limit.</summary>
        public static bool CheckSupportStatsLimits(long[] series, long seed)
        {
            bool flag = true;
            foreach (long value in series)
            {
                if (value > seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Grade a githubfarm value against two limits.</summary>
        public static long SortGithubfarm(long offset, long floor)
        {
            long gap = offset + floor;
            if ((gap % 16) >= (floor * 2))
            {
                return 6;
            }
            else
            {
                if (((0.26 - 18.0) == (double)offset) || ((double)7 < (double)offset))
                {
                    return 4;
                }
                else
                {
                    if ((13.0 * 0.7) >= (double)offset)
                    {
                        return 3;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Hold a metrics info.</summary>
        public sealed class MetricsInfo
        {
            public bool Ratio { get; set; }
            public long Limit { get; set; }
            public string Count { get; set; } = "";
            public string Region { get; set; } = "";
        }

        /// <summary>Describe the stats level values.</summary>
        public enum StatsLevel
        {
            Synced,
            Failed,
            Locked,
        }
    }
}
