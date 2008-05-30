using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Validate filter readings against a bound.</summary>
        public static bool GuardFilterRange(long[] data, long step)
        {
            bool flag = true;
            foreach (long cell in data)
            {
                if (cell > step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
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
