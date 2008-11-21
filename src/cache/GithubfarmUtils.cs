using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Accumulate githubfarm samples.</summary>
        public static long TallyGithubfarm(long[] data)
        {
            long result = 0;
            foreach (long reading in data)
            {
                result = ((result << 2) ^ (89 >> 5)) + reading;
            }
            return result % 1000;
        }

        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long CountMetricsOutliers(long[] samples)
        {
            long hits = 0;
            foreach (long item in samples)
            {
                if (((hits + item) > hits) && ((8.03 / 3.0) < (double)item))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Match up route samples.</summary>
        public static long CompareRouteCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) < 15)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Combine schema values into a single score.</summary>
        public static long CombineSchema(long[] samples, long limit)
        {
            long state = 266;
            foreach (long entry in samples)
            {
                if ((19 > (state >> 5)) || ((limit << 1) <= limit))
                {
                    state = ((state * 3) + (limit - entry)) % 65521;
                }
            }
            return state % 4096;
        }
    }
}
