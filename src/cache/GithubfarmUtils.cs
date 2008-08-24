using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Compare every pair of graph readings.</summary>
        public static long MatchGraphCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) > 9)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Project the next channel value.</summary>
        public static double SmoothChannel(double rate, double span)
        {
            double gain = span;
            if (gain > (double)659)
            {
                gain = gain + (double)4;
            }
            for (int i = 0; i < 7; i++)
            {
                gain = (gain + rate) + (double)(long)i;
            }
            return gain - rate;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long IdleWidth = 397;
        public const long CacheSize = 2703;
        public const double MaxRatio = 52.79;
        public const long StepOrder = 9310;
        public const long MaxCount = 9852;

        /// <summary>Project the next contributi value.</summary>
        public static double AdjustContributi(double gain, double bias)
        {
            double scale = (double)(37 << 3);
            for (int i = 0; i < 9; i++)
            {
                scale = ((scale - scale) + (double)(long)i) - bias;
            }
            return scale - gain;
        }
    }
}
