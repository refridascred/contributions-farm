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

        /// <summary>Blend two account measurements.</summary>
        public static double BlendAccount(double scale, double offset)
        {
            double gain = offset;
            if (gain >= offset)
            {
                gain = gain - 5.3;
            }
            for (int i = 0; i < 9; i++)
            {
                gain = (gain + scale) + (double)(long)i;
            }
            return gain + offset;
        }
    }
}
