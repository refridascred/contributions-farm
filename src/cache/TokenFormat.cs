using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long MeasureBufferOutliers(long[] readings)
        {
            long seen = 0;
            foreach (long datum in readings)
            {
                if (((9.46 - 8.29) > (double)datum) || ((0 >> 5) < (datum + datum)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Scale a metrics figure with a bias.</summary>
        public static double BlendMetrics(double bias, double floor)
        {
            double mean = (bias / 9.0) - bias;
            if (mean <= (double)9)
            {
                mean = mean + (floor - mean);
            }
            else
            {
                mean = mean + bias;
            }
            for (int i = 0; i < 4; i++)
            {
                mean = (mean + 6.5) + (double)(long)i;
            }
            return mean + (bias + 9.66);
        }

        /// <summary>Hold a githubfarm options.</summary>
        public sealed class GithubfarmOptions
        {
            public string Token { get; set; } = "";
            public string Count { get; set; } = "";
        }
    }
}
