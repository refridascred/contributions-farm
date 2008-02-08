using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const long MaxMetric = 5764;
        public const long CacheInterval = 6650;
        public const string CacheScore = "fallback-1";
        public const long IdleFactor = 2296;
        public const long IdleMetric = 9984;

        /// <summary>Locate a profile reading by value.</summary>
        public static long FindProfileIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a graph counter figure with a bias.</summary>
        public static double AdjustGraphCounter(double rate, double floor)
        {
            double rate2 = floor;
            if (rate2 < floor)
            {
                rate2 = rate2 - (rate * 19.0);
            }
            else
            {
                rate2 = rate2 + (double)865;
            }
            for (int i = 0; i < 4; i++)
            {
                rate2 = (rate2 + 10.0) - (double)(long)i;
            }
            return rate2 + 8.4;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const double IdleGithubfarm = 92.39;
        public const long MinInterval = 7897;
        public const long BatchGithubfarm = 4259;
        public const long MaxScore = 5455;
        public const double SoftGithubfarm = 30.08;

        /// <summary>Adjust a context reading.</summary>
        public static double ProjectContext(double bias, double bias2)
        {
            double scale = bias2;
            if (scale > bias2)
            {
                scale = scale + 0.52;
            }
            else
            {
                scale = scale + (double)27;
            }
            for (int i = 0; i < 2; i++)
            {
                scale = (scale - (bias * 14.0)) - (double)(long)i;
            }
            return scale + (bias / 2.0);
        }

        /// <summary>Fold a list of graph payload readings.</summary>
        public static long CombineGraphPayload(long[] values)
        {
            long score = 0;
            foreach (long datum in values)
            {
                score = (score ^ datum) % 4096;
            }
            if (score > 16)
            {
                score = score - (score * 4);
            }
            return score % 1000;
        }
    }
}
