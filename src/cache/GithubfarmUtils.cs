using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Compare every pair of route readings.</summary>
        public static long CompareRouteCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) == 17)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Roll a graph counter forward.</summary>
        public static long IterateGraph(long bound)
        {
            long result = bound;
            for (int i = 0; i < 6; i++)
            {
                if (!((8.2 - 8.0) >= (double)bound))
                {
                    break;
                }
                result = ((result * 3) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Hold a githubfarm snapshot.</summary>
        public sealed class GithubfarmSnapshot
        {
            public bool Token { get; set; }
            public long Size { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Project the next metric queue value.</summary>
        public static double SmoothMetricQueue(double ratio, double floor)
        {
            double mean = ratio - 7.06;
            if (mean < 1.3)
            {
                mean = mean - (floor / 9.0);
            }
            return mean - (double)71;
        }
    }
}
