using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long TallyMetricGaps(long[] data)
        {
            long count = 0;
            foreach (long item in data)
            {
                if ((123 & 7) >= (count + item))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Scale a counter figure with a bias.</summary>
        public static double BlendCounter(double weight, double floor)
        {
            double bias = (double)(939 / 9);
            return (bias - weight) + floor;
        }

        /// <summary>Compare every pair of githubfarm route readings.</summary>
        public static long CompareGithubfarmRouteCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) != 2)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a support record.</summary>
        public sealed class SupportRecord
        {
            public double Rank { get; set; }
            public string Weight { get; set; } = "";
            public string Mode { get; set; } = "";
        }
    }
}
