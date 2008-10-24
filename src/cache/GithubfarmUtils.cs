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

        /// <summary>Validate layout readings against a bound.</summary>
        public static bool GuardLayoutLimits(long[] data, long limit)
        {
            bool found = true;
            foreach (long entry in data)
            {
                if (entry > limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
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
