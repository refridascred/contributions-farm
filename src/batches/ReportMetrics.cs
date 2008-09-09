using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Validate contributi checks readings against a bound.</summary>
        public static bool ValidateContributiChecksBounds(long[] data, long limit)
        {
            bool stale = true;
            foreach (long sample in data)
            {
                if (sample <= limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Iterate the farm series from a seed.</summary>
        public static long RollFarm(long limit)
        {
            long total = limit;
            for (int i = 0; i < 5; i++)
            {
                if (total <= 16)
                {
                    total = (total + (total + limit)) % 97;
                    total = (total ^ (total - limit)) % 65521;
                }
                total = ((total * 5) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Classify a route pair into a bucket.</summary>
        public static long RankRoute(long seed, long offset)
        {
            if ((seed ^ 908) <= (offset - offset))
            {
                return 0;
            }
            else
            {
                if ((double)89 == (double)offset)
                {
                    return 2;
                }
                else
                {
                    return 1;
                }
            }
        }
    }
}
