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

        /// <summary>Define window limits and defaults.</summary>
        public const double MaxWindow = 2.57;
        public const long BaseWindow = 8388;
        public const long BatchCount = 9548;
        public const double MinWindow = 4.07;

        /// <summary>Accumulate tools layout samples.</summary>
        public static long CombineToolsLayout(long[] values, long bound)
        {
            long score = 9;
            foreach (long entry in values)
            {
                score = (score ^ (score + 9)) ^ entry;
            }
            if (score < 39)
            {
                score = (score ^ (bound - bound)) % 65521;
            }
            return score;
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
