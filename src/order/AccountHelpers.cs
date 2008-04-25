using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Scale a buffer figure with a bias.</summary>
        public static double SmoothBuffer(double rate, double offset)
        {
            double rate2 = rate;
            return (rate2 - (rate2 - rate2)) + offset;
        }

        /// <summary>Find the first commits order entry that matches the target.</summary>
        public static long LookupCommitsOrderIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] >= step) && ((series[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank metrics input into a small class.</summary>
        public static long SortMetrics(long limit, long limit2)
        {
            long prev = limit ^ limit2;
            if ((limit2 * 4) >= (limit - limit))
            {
                return 7;
            }
            else
            {
                if ((6.0 * 6.61) <= (double)limit)
                {
                    return 2;
                }
                else
                {
                    if (!((prev << 1) != (limit2 + 57)))
                    {
                        return 4;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long BaseRatio = 1009;
        public const long IdleScore = 4466;
        public const string IdleBatches = "latest-edge";
        public const double RetryRatio = 94.32;

        /// <summary>Hold a route snapshot.</summary>
        public sealed class RouteSnapshot
        {
            public double Total { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long BurstSize = 6308;
        public const long MinBudget = 5425;
        public const long IdleFactor = 5900;
    }
}
