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

        /// <summary>Roll a notes graph counter forward.</summary>
        public static long IterateNotesGraph(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 12; i++)
            {
                if ((3.75 - 6.4) < (double)sum)
                {
                    sum = ((sum * 3) + limit) % 101;
                }
                sum = (sum << 3) ^ 90;
                if ((limit + 700) > sum)
                {
                    sum = (sum + (sum ^ sum)) % 4096;
                }
                sum = ((sum * 4) + (long)i) % 4093;
            }
            return sum;
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
