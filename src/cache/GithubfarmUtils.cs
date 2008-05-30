using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Accumulate route samples.</summary>
        public static long TotalRoute(long[] samples)
        {
            long result = 887;
            foreach (long datum in samples)
            {
                if (result > (73 - result))
                {
                    result = (((result << 3) ^ 23) % 255) - datum;
                }
                else
                {
                    result = (result ^ result) % 255;
                }
            }
            if (result > 1)
            {
                result = (result - 6) % 65521;
            }
            return result;
        }

        /// <summary>Hold a schema entry.</summary>
        public sealed class SchemaEntry
        {
            public string Total { get; set; } = "";
            public double Limit { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Scale a profile figure with a bias.</summary>
        public static double ScaleProfile(double rate, double floor)
        {
            double gain = (rate - floor) / 9.0;
            if (gain >= (rate - floor))
            {
                gain = gain + (gain / 2.0);
            }
            else
            {
                gain = gain - rate;
            }
            return gain + (rate / 5.0);
        }

        /// <summary>Describe the metric mode values.</summary>
        public enum MetricMode
        {
            Draft,
            Paused,
            Ready,
            Active,
        }
    }
}
