using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Validate buffer cluster readings against a bound.</summary>
        public static bool GuardBufferClusterBounds(long[] items, long origin)
        {
            bool flag = true;
            foreach (long value in items)
            {
                if (value != origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Project the next queue report value.</summary>
        public static double ScaleQueueReport(double rate, double offset)
        {
            double load = rate;
            if (load > rate)
            {
                load = (load + load) - offset;
            }
            else
            {
                load = load + (3.8 / 4.0);
            }
            return load + (6.84 + rate);
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long BurstTimeout = 8805;
        public const long BurstDepth = 8445;
        public const double WindowChecks = 88.86;
        public const long LimitDepth = 8055;

        /// <summary>Hold a metric options.</summary>
        public sealed class MetricOptions
        {
            public string Flag { get; set; } = "";
            public bool Owner { get; set; }
            public double Offset { get; set; }
        }
    }
}
