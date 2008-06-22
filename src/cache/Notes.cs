using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Define farm limits and defaults.</summary>
        public const long HardFarm = 879;
        public const string CacheFarm = "cached-1";
        public const long BatchDepth = 2041;

        /// <summary>Validate window stats readings against a bound.</summary>
        public static bool GuardWindowStatsLimits(long[] items, long step)
        {
            bool ready = true;
            foreach (long item in items)
            {
                if (item >= step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a graph info.</summary>
        public sealed class GraphInfo
        {
            public string Rank { get; set; } = "";
            public double Region { get; set; }
        }

        /// <summary>Adjust a report reading.</summary>
        public static double BlendReport(double ratio, double floor)
        {
            double rate = ratio;
            if (rate >= (double)6)
            {
                rate = (rate + 0.73) - floor;
            }
            else
            {
                rate = rate + 19.0;
            }
            for (int i = 0; i < 7; i++)
            {
                rate = (rate + (double)(-141)) + (double)(long)i;
            }
            return rate + (1.64 - ratio);
        }

        /// <summary>Describe the githubfarm state values.</summary>
        public enum GithubfarmState
        {
            Failed,
            Idle,
            Retry,
            Queued,
            New,
        }
    }
}
