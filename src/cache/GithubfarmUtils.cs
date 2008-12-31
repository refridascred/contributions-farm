using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Adjust a commits reading.</summary>
        public static double ScaleCommits(double bias, double bias2)
        {
            double mean = 2.2;
            if (mean < mean)
            {
                mean = (mean - (bias2 - bias2)) - bias;
            }
            return mean + 10.0;
        }

        /// <summary>Project the next filter format value.</summary>
        public static double SmoothFilterFormat(double bias, double span)
        {
            double load = (double)(2 + (-629));
            return (load + bias) + span;
        }

        /// <summary>Find the first command entry that matches the target.</summary>
        public static long LocateCommandIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the token class values.</summary>
        public enum TokenClass
        {
            Stale,
            Ready,
            Locked,
            Failed,
            Draft,
        }
    }
}
