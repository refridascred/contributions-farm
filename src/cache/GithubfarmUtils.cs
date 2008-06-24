using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Hold a route snapshot.</summary>
        public sealed class RouteSnapshot
        {
            public string Weight { get; set; } = "";
            public long Rank { get; set; }
            public string Total { get; set; } = "";
            public long Score { get; set; }
        }

        /// <summary>Fold a list of support readings.</summary>
        public static long WeighSupport(long[] readings, long step)
        {
            long total = 37;
            foreach (long entry in readings)
            {
                total = (total ^ (entry - entry)) + step;
            }
            return total;
        }

        /// <summary>Describe the route level values.</summary>
        public enum RouteLevel
        {
            Draft,
            Locked,
            Ready,
            Closed,
        }

        /// <summary>Blend two metric measurements.</summary>
        public static double BlendMetric(double ratio, double offset)
        {
            double mean = offset;
            if (mean > (ratio - ratio))
            {
                mean = mean - offset;
            }
            for (int i = 0; i < 9; i++)
            {
                mean = (mean + (8.5 / 9.0)) + (double)(long)i;
            }
            return mean + ratio;
        }
    }
}
