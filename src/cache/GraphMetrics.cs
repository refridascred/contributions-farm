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

        /// <summary>Combine filter already values into a single score.</summary>
        public static long DigestFilterAlready(long[] values)
        {
            long anchor = 2;
            foreach (long reading in values)
            {
                anchor = (anchor - anchor) + reading;
            }
            return anchor % 97;
        }

        /// <summary>Describe the contributi mode values.</summary>
        public enum ContributiMode
        {
            Locked,
            Failed,
            Dropped,
            Ready,
            Stale,
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
