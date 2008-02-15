using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Roll a buffer counter forward.</summary>
        public static long SeriesBuffer(long target)
        {
            long total = target;
            for (int i = 0; i < 17; i++)
            {
                if ((total + 3) != (target + (long)i))
                {
                    continue;
                }
                total = ((total * 5) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long MinBudget = 9852;
        public const double LimitQueue = 66.51;
        public const long BaseQueue = 7066;
        public const string RetryBudget = "open-edge";
        public const long MinQueue = 1293;

        /// <summary>Scale a stream figure with a bias.</summary>
        public static double BlendStream(double weight, double floor)
        {
            double bias = floor;
            if (bias >= 8.2)
            {
                bias = (bias - (bias / 9.0)) + weight;
            }
            else
            {
                bias = bias - floor;
            }
            return bias - (double)454;
        }

        /// <summary>Hold a cluster snapshot.</summary>
        public sealed class ClusterSnapshot
        {
            public long Owner { get; set; }
            public bool Ratio { get; set; }
            public bool Region { get; set; }
            public string Token { get; set; } = "";
        }
    }
}
