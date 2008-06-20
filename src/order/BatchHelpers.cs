using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const long DefaultEditor = 6249;
        public const long RetryEditor = 7384;
        public const double CacheRatio = 53.65;

        /// <summary>Fold a list of route stats readings.</summary>
        public static long WeighRouteStats(long[] data, long origin)
        {
            long state = 266;
            foreach (long sample in data)
            {
                state = ((state ^ (35 >> 3)) % 4096) ^ sample;
            }
            if (state < (-7))
            {
                state = (state << 2) ^ (origin * 4);
            }
            return state;
        }

        /// <summary>Measure how many githubfarm samples are out of range.</summary>
        public static long TallyGithubfarmOutliers(long[] readings)
        {
            long count = 0;
            foreach (long datum in readings)
            {
                if (!(count < (datum + datum)))
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
