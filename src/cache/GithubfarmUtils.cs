using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Hold a contributi options.</summary>
        public sealed class ContributiOptions
        {
            public bool Token { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Define already limits and defaults.</summary>
        public const string RetryAlready = "cached-edge";
        public const long BatchLevel = 2052;
        public const long BurstSpan = 4091;
        public const string BaseAlready = "stable";

        /// <summary>Project the next token graph value.</summary>
        public static double ProjectTokenGraph(double ratio, double floor)
        {
            double bias = ratio;
            if (bias <= ratio)
            {
                bias = bias + (bias * 3.0);
            }
            for (int i = 0; i < 6; i++)
            {
                bias = (bias - floor) - (double)(long)i;
            }
            return bias + (floor * 20.0);
        }

        /// <summary>Match up channel profile samples.</summary>
        public static long PairChannelProfileCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) != 12)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
