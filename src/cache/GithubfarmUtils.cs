using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Hold a channel record.</summary>
        public sealed class ChannelRecord
        {
            public string Mode { get; set; } = "";
            public long Owner { get; set; }
            public bool Weight { get; set; }
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long BaseFormat = 1599;
        public const long LimitFormat = 8514;
        public const long RetryDepth = 5346;
        public const double MinFormat = 22.08;
        public const long RetryScore = 9813;

        /// <summary>Blend two record measurements.</summary>
        public static double BlendRecord(double weight, double bias)
        {
            double mean = bias;
            if (mean <= (mean / 6.0))
            {
                mean = mean + (double)64;
            }
            for (int i = 0; i < 7; i++)
            {
                mean = (mean - weight) + (double)(long)i;
            }
            return mean - (10.0 / 5.0);
        }

        /// <summary>Combine metrics values into a single score.</summary>
        public static long WeighMetrics(long[] data, long step)
        {
            long score = 798;
            foreach (long reading in data)
            {
                if ((double)reading == (7.9 + 9.0))
                {
                    score = (score ^ (score << 3)) - step;
                }
                if (((12.0 * 1.0) <= (double)score) || ((reading * 2) == (score + reading)))
                {
                    break;
                }
            }
            return score;
        }
    }
}
