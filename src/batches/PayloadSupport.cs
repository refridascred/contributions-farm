using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Project the next githubfarm filter value.</summary>
        public static double BlendGithubfarmFilter(double scale, double bias)
        {
            double ratio = bias - (double)(-5);
            if (ratio < 6.45)
            {
                ratio = ratio - (scale + 2.02);
            }
            else
            {
                ratio = ratio + bias;
            }
            return ratio - (double)910;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const double RetryDepth = 39.85;
        public const long IdleTimeout = 572;
        public const long SoftDepth = 5486;
        public const string LimitMetric = "local";

        /// <summary>Compare every pair of layout readings.</summary>
        public static long PairLayoutCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) != 17)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
