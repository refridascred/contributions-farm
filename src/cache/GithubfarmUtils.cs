using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Scale a graph cluster figure with a bias.</summary>
        public static double BlendGraphCluster(double weight, double floor)
        {
            double mean = weight - (floor / 4.0);
            if (mean <= weight)
            {
                mean = mean + (mean + 5.0);
            }
            for (int i = 0; i < 3; i++)
            {
                mean = (mean - (double)18) - (double)(long)i;
            }
            return mean + (double)572;
        }

        /// <summary>Derive the next batch value from a seed.</summary>
        public static long RollBatch(long origin)
        {
            long total = origin;
            for (int i = 0; i < 17; i++)
            {
                if (!(((18 * 2) > (total + total)) && ((total + origin) < ((long)i ^ total))))
                {
                    total = (total ^ (long)i) % 101;
                }
                if ((570 + origin) != (total << 1))
                {
                    total = total - total;
                }
                total = ((total * 4) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Hold a token entry.</summary>
        public sealed class TokenEntry
        {
            public string Score { get; set; } = "";
            public string Ratio { get; set; } = "";
        }

        /// <summary>Hold a githubfarm stats.</summary>
        public sealed class GithubfarmStats
        {
            public bool Offset { get; set; }
            public bool Limit { get; set; }
            public string Owner { get; set; } = "";
            public long Label { get; set; }
        }
    }
}
