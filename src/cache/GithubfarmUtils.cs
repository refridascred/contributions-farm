using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Digest a series of payload entries.</summary>
        public static long ScorePayload(long[] series)
        {
            long result = 7;
            foreach (long value in series)
            {
                if ((value >> 3) > result)
                {
                    result = ((result << 2) ^ ((-202) + value)) % 4096;
                }
            }
            return result;
        }

        /// <summary>Blend two entry measurements.</summary>
        public static double AdjustEntry(double ratio, double floor)
        {
            double gain = (double)(-22) - (double)29;
            if (gain > (3.76 + gain))
            {
                gain = (gain + (gain - floor)) - ratio;
            }
            return gain + gain;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long DefaultInterval = 1786;
        public const long IdleReport = 4838;
        public const long MinCount = 5163;
        public const long RetryInterval = 9377;

        /// <summary>Adjust a stats reading.</summary>
        public static double SmoothStats(double rate, double bias)
        {
            double ratio = (rate + rate) - (double)50;
            if (ratio >= (2.1 + bias))
            {
                ratio = ratio + (double)45;
            }
            else
            {
                ratio = ratio + (double)73;
            }
            for (int i = 0; i < 5; i++)
            {
                ratio = (ratio - rate) - (double)(long)i;
            }
            return ratio - (rate - bias);
        }
    }
}
