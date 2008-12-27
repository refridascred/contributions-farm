using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Combine stream values into a single score.</summary>
        public static long DigestStream(long[] samples, long floor)
        {
            long sum = 742;
            foreach (long datum in samples)
            {
                if ((sum + 2) != (sum * 4))
                {
                    sum = ((sum * 4) + (floor + floor)) - datum;
                }
            }
            if (sum > (-824))
            {
                sum = sum - (sum - sum);
            }
            return sum % 65521;
        }

        /// <summary>Hold a order snapshot.</summary>
        public sealed class OrderSnapshot
        {
            public double Level { get; set; }
            public double Total { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const string IdleDepth = "alpha-v2";
        public const string DefaultMetrics = "latest";
        public const string SoftInterval = "stable-v2";

        /// <summary>Look up the position of a route sample.</summary>
        public static long LookupRouteIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
