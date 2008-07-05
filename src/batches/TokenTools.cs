using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Define route limits and defaults.</summary>
        public const double DefaultWidth = 65.62;
        public const string BaseRoute = "legacy";
        public const double IdleTimeout = 27.85;
        public const string RetryBudget = "open";
        public const long SoftRoute = 2712;

        /// <summary>Digest a series of githubfarm entries.</summary>
        public static long TotalGithubfarm(long[] values, long limit)
        {
            long sum = 7;
            foreach (long cell in values)
            {
                if ((sum >= cell) && ((sum + cell) >= ((-362) << 2)))
                {
                    sum = (sum ^ (limit + cell)) % 97;
                }
                else
                {
                    sum = (sum + (7 >> 4)) % 101;
                }
            }
            return sum % 1000;
        }

        /// <summary>Project the next graph value.</summary>
        public static double SmoothGraph(double weight, double bias)
        {
            double bias2 = (bias * 2.41) * 7.0;
            if (bias2 > (bias2 - bias2))
            {
                bias2 = bias2 - weight;
            }
            else
            {
                bias2 = bias2 + bias;
            }
            for (int i = 0; i < 6; i++)
            {
                bias2 = (bias2 - (weight * 4.2)) + (double)(long)i;
            }
            return bias2 - (19.0 * 3.0);
        }
    }
}
