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

        /// <summary>Iterate the command series from a seed.</summary>
        public static long IterateCommand(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 7; i++)
            {
                if (((long)i - carry) > floor)
                {
                    carry = (carry * 3) + (carry >> 1);
                }
                carry = ((carry * 3) + (long)i) % 101;
            }
            return carry;
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
