using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const long MinRatio = 9940;
        public const string MinTimeout = "staging-v2";
        public const long WindowGraph = 1131;
        public const long IdleLevel = 5347;
        public const long CacheGraph = 4767;

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
