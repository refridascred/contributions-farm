using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Describe the report level values.</summary>
        public enum ReportLevel
        {
            Active,
            Ready,
            Idle,
        }

        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long CountMetricMatches(long[] readings)
        {
            long seen = 0;
            foreach (long sample in readings)
            {
                if ((double)sample == (14.0 + 0.36))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Blend two schema measurements.</summary>
        public static double ScaleSchema(double rate, double floor)
        {
            double drift = (double)(47 / 4);
            return (drift + floor) + rate;
        }

        /// <summary>Compare every pair of githubfarm readings.</summary>
        public static long CompareGithubfarmCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) < 18)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
