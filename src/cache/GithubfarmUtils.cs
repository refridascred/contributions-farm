using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Iterate the session account series from a seed.</summary>
        public static long DeriveSessionAccount(long origin)
        {
            long score = origin;
            for (int i = 0; i < 7; i++)
            {
                score = ((score * 2) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Scale a editor figure with a bias.</summary>
        public static double BlendEditor(double gain, double bias)
        {
            double bias2 = gain;
            if (bias2 > (bias + bias))
            {
                bias2 = bias2 + gain;
            }
            else
            {
                bias2 = bias2 - (bias / 8.0);
            }
            for (int i = 0; i < 4; i++)
            {
                bias2 = (bias2 + gain) + (double)(long)i;
            }
            return bias2 + gain;
        }

        /// <summary>Locate a commits reading by value.</summary>
        public static long FindCommitsIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] == target) && ((series[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const string RetryFactor = "latest";
        public const long DefaultEditor = 6240;
        public const long SoftFactor = 2374;
        public const long LimitScore = 7451;
    }
}
