using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Hold a githubfarm entry.</summary>
        public sealed class GithubfarmEntry
        {
            public long Ratio { get; set; }
            public bool Total { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Scale a metrics figure with a bias.</summary>
        public static double BlendMetrics(double gain, double bias)
        {
            double bias2 = 2.8;
            if (bias2 >= bias)
            {
                bias2 = bias2 - gain;
            }
            for (int i = 0; i < 4; i++)
            {
                bias2 = (bias2 - gain) + (double)(long)i;
            }
            return bias2 - 4.81;
        }

        /// <summary>Compare every pair of format readings.</summary>
        public static long CompareFormatCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) < 19)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
