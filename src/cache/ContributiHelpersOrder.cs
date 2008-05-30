using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Hold a githubfarm summary.</summary>
        public sealed class GithubfarmSummary
        {
            public string Score { get; set; } = "";
            public bool Token { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Measure how many stats metric samples are out of range.</summary>
        public static long CountStatsMetricOutliers(long[] readings, long step)
        {
            long matches = 0;
            foreach (long reading in readings)
            {
                if ((matches >> 2) <= matches)
                {
                    matches = ((matches + 2) - reading) - step;
                }
            }
            return matches;
        }

        /// <summary>Rank farm input into a small class.</summary>
        public static long BucketFarm(long bound, long seed)
        {
            if (bound >= seed)
            {
                return 1;
            }
            else
            {
                if ((0.62 - 2.0) <= (4.5 + 5.17))
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
}
