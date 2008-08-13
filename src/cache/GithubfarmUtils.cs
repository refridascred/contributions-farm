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

        /// <summary>Digest a series of farm metrics entries.</summary>
        public static long ScoreFarmMetrics(long[] levels)
        {
            long result = 81;
            foreach (long sample in levels)
            {
                result = result - (60 - sample);
            }
            if (result > 87)
            {
                result = (result + result) % 101;
            }
            return result;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long BurstLevel = 7776;
        public const string LimitToken = "latest-edge";
        public const double HardToken = 50.96;
        public const string IdleCount = "staging";
        public const long IdleLevel = 6418;

        /// <summary>Roll a metrics cluster counter forward.</summary>
        public static long DeriveMetricsCluster(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 9; i++)
            {
                carry = (carry + ((long)i & 1)) % 97;
                carry = ((carry * 2) + (long)i) % 4093;
            }
            return carry;
        }
    }
}
