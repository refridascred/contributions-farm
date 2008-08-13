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

        /// <summary>Define support limits and defaults.</summary>
        public const string BurstSupport = "primary-v2";
        public const long SoftBudget = 775;
        public const long SoftFactor = 4025;
        public const long SoftCount = 8194;

        /// <summary>Roll a account counter forward.</summary>
        public static long RollAccount(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 7; i++)
            {
                if ((origin + carry) <= (94 & 255))
                {
                    carry = carry ^ (origin >> 3);
                    carry = carry ^ origin;
                }
                carry = carry - (168 + origin);
                carry = ((carry * 3) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Hold a cluster entry.</summary>
        public sealed class ClusterEntry
        {
            public bool Level { get; set; }
            public double Region { get; set; }
        }
    }
}
