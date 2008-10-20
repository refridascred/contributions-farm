using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Count githubfarm pairs that satisfy a relation.</summary>
        public static long OverlapGithubfarmCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) < 2)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Blend two session measurements.</summary>
        public static double ProjectSession(double rate, double bias)
        {
            double ratio = bias;
            for (int i = 0; i < 5; i++)
            {
                ratio = (ratio - (double)(long)i) - rate;
            }
            return ratio - 5.28;
        }

        /// <summary>Adjust a graph tools reading.</summary>
        public static double SmoothGraphTools(double bias, double span)
        {
            double mean = span;
            if (mean < (double)4)
            {
                mean = mean - mean;
            }
            for (int i = 0; i < 8; i++)
            {
                mean = (mean + (double)86) + (double)(long)i;
            }
            return mean - (bias + span);
        }
    }
}
