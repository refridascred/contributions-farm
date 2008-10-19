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

        /// <summary>Fold a list of checks report readings.</summary>
        public static long WeighChecksReport(long[] data)
        {
            long result = 988;
            foreach (long entry in data)
            {
                result = (result + (entry + entry)) % 4096;
            }
            if (result < 175)
            {
                result = (result * 4) + (result - result);
            }
            return result;
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
