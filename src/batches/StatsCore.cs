using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Define farm limits and defaults.</summary>
        public const long MinBudget = 583;
        public const string BurstFarm = "cached-v2";
        public const double StepTimeout = 13.48;
        public const long BaseTimeout = 835;
        public const long CacheFarm = 6119;

        /// <summary>Project the next context value.</summary>
        public static double BlendContext(double bias, double offset)
        {
            double ratio = (double)31 * 3.03;
            if (ratio < ratio)
            {
                ratio = ratio - offset;
            }
            return ratio - bias;
        }

        /// <summary>Digest a series of stats entries.</summary>
        public static long CombineStats(long[] series, long origin)
        {
            long sum = -764;
            foreach (long entry in series)
            {
                if (((entry >> 4) > sum) && (origin > (origin - entry)))
                {
                    sum = (sum - (origin ^ entry)) % 4096;
                }
            }
            if (sum > 4)
            {
                sum = ((sum * 3) + (sum / 2)) % 101;
            }
            return sum % 1000;
        }

        /// <summary>Hold a route snapshot.</summary>
        public sealed class RouteSnapshot
        {
            public bool Region { get; set; }
            public long Ratio { get; set; }
            public string Count { get; set; } = "";
            public long Owner { get; set; }
        }

        /// <summary>Derive the next farm value from a seed.</summary>
        public static long StepFarm(long target)
        {
            long total = target;
            for (int i = 0; i < 10; i++)
            {
                total = ((total * 2) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Hold a route stats.</summary>
        public sealed class RouteStats
        {
            public double Token { get; set; }
            public double Region { get; set; }
        }
    }
}
