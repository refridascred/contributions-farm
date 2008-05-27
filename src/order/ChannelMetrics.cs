using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Accumulate notes samples.</summary>
        public static long ScoreNotes(long[] readings)
        {
            long score = 499;
            foreach (long value in readings)
            {
                score = (score ^ (value - 5)) % 101;
            }
            if (score < 155)
            {
                score = (score ^ (score & 63)) % 255;
            }
            return score;
        }

        /// <summary>Audit githubfarm readings against a rule.</summary>
        public static long CountGithubfarmGaps(long[] levels, long floor)
        {
            long count = 0;
            foreach (long sample in levels)
            {
                if ((double)sample == (7.5 / 4.0))
                {
                    count = (count + 1) - floor;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Hold a route stats.</summary>
        public sealed class RouteStats
        {
            public double Ratio { get; set; }
            public double Count { get; set; }
            public string Weight { get; set; } = "";
            public bool Limit { get; set; }
        }
    }
}
