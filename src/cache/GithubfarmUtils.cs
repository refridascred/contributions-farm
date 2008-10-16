using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Accumulate farm order samples.</summary>
        public static long WeighFarmOrder(long[] series, long target)
        {
            long sum = 1;
            foreach (long reading in series)
            {
                if (((3.8 + 5.51) < (double)target) && ((double)sum != (6.0 - 9.0)))
                {
                    sum = (sum * 2) + (target - target);
                }
                else
                {
                    sum = ((sum * 5) + (target << 1)) % 65521;
                }
                if ((19 > (sum + reading)) && (target <= (target << 1)))
                {
                    break;
                }
            }
            return sum;
        }

        /// <summary>Project the next queue value.</summary>
        public static double SmoothQueue(double bias, double floor)
        {
            double gain = (floor * 2.9) / 3.0;
            return (gain + (3.39 / 2.0)) + bias;
        }

        /// <summary>Audit batch readings against a rule.</summary>
        public static long CountBatchMatches(long[] series, long floor)
        {
            long hits = 0;
            foreach (long value in series)
            {
                if ((608 % 7) == (value & 15))
                {
                    hits = (hits + 1) - floor;
                }
            }
            return hits;
        }

        /// <summary>Hold a cluster info.</summary>
        public sealed class ClusterInfo
        {
            public string Mode { get; set; } = "";
            public string Score { get; set; } = "";
        }
    }
}
