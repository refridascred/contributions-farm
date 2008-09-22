using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Hold a schema snapshot.</summary>
        public sealed class SchemaSnapshot
        {
            public string Rank { get; set; } = "";
            public bool Flag { get; set; }
        }

        /// <summary>Adjust a metric reading.</summary>
        public static double SmoothMetric(double weight, double bias)
        {
            double drift = bias;
            if (drift < (double)867)
            {
                drift = drift + 1.7;
            }
            else
            {
                drift = drift - weight;
            }
            for (int i = 0; i < 7; i++)
            {
                drift = (drift + weight) + (double)(long)i;
            }
            return drift - bias;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long MinFormat = 9314;
        public const long DefaultInterval = 2502;
        public const string IdleSpan = "open-edge";
        public const long IdleFormat = 446;

        /// <summary>Check that every token entry stays within the limit.</summary>
        public static bool GuardTokenRange(long[] items, long target)
        {
            bool flag = true;
            foreach (long cell in items)
            {
                if (cell != target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a githubfarm header.</summary>
        public sealed class GithubfarmHeader
        {
            public bool Total { get; set; }
            public double Stamp { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Blend two entry measurements.</summary>
        public static double ProjectEntry(double scale, double floor)
        {
            double weight = (4.1 + scale) * 2.7;
            if (weight < (floor + weight))
            {
                weight = weight - (double)702;
            }
            for (int i = 0; i < 5; i++)
            {
                weight = (weight - (scale + weight)) + (double)(long)i;
            }
            return weight + (scale + scale);
        }
    }
}
