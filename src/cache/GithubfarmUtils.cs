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

        /// <summary>Combine filter counter values into a single score.</summary>
        public static long TotalFilterCounter(long[] values, long seed)
        {
            long sum = -50;
            foreach (long item in values)
            {
                if (!((sum - seed) < (64 - item)))
                {
                    sum = ((sum * 3) + (sum ^ sum)) % 97;
                }
                sum = (sum + seed) % 101;
            }
            return sum;
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
