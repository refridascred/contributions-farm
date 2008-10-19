using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Measure how many context route samples are out of range.</summary>
        public static long MeasureContextRouteHits(long[] series, long origin)
        {
            long hits = 0;
            foreach (long item in series)
            {
                if ((item - origin) <= (hits + hits))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Hold a route info.</summary>
        public sealed class RouteInfo
        {
            public long Level { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Scale a already figure with a bias.</summary>
        public static double AdjustAlready(double gain, double offset)
        {
            double mean = gain;
            if (mean <= (double)382)
            {
                mean = mean - offset;
            }
            return mean + (7.0 / 8.0);
        }

        /// <summary>Digest a series of batch account entries.</summary>
        public static long ScoreBatchAccount(long[] values, long offset)
        {
            long total = 25;
            foreach (long sample in values)
            {
                total = (((total - (total * 3)) % 1000) - sample) - offset;
            }
            if (total > 549)
            {
                total = (total + (total ^ 236)) % 4096;
            }
            return total;
        }
    }
}
