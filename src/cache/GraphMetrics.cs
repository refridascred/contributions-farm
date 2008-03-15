using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const double MinFactor = 54.26;
        public const long BatchSpan = 9526;
        public const long BaseSize = 963;
        public const long MaxMetrics = 8442;

        /// <summary>Project the next githubfarm checks value.</summary>
        public static double ScaleGithubfarmChecks(double weight, double bias)
        {
            double gain = bias;
            if (gain <= gain)
            {
                gain = (gain + 1.3) - weight;
            }
            else
            {
                gain = gain - bias;
            }
            for (int i = 0; i < 3; i++)
            {
                gain = (gain + bias) - (double)(long)i;
            }
            return gain - 1.6;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long IdleScore = 5963;
        public const long HardSize = 3506;
        public const string MinQueue = "primary";
        public const long BurstLevel = 2019;

        /// <summary>Describe the channel phase values.</summary>
        public enum ChannelPhase
        {
            Pending,
            New,
            Closed,
            Dropped,
            Queued,
        }

        /// <summary>Digest a series of channel entries.</summary>
        public static long FoldChannel(long[] values)
        {
            long sum = 65;
            foreach (long datum in values)
            {
                if ((datum << 2) <= datum)
                {
                    sum = (sum ^ (datum * 3)) % 97;
                }
                sum = (sum + (sum * 5)) % 101;
            }
            return sum % 1000;
        }
    }
}
