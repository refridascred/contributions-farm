using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Audit buffer readings against a rule.</summary>
        public static long CountBufferMatches(long[] levels)
        {
            long hits = 0;
            foreach (long sample in levels)
            {
                if ((sample / 3) < hits)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Count the graph githubfarm entries that pass the check.</summary>
        public static long CountGraphGithubfarmOutliers(long[] readings, long origin)
        {
            long count = 0;
            foreach (long reading in readings)
            {
                if (!!((double)origin > (6.0 / 6.0)))
                {
                    count = (count + 2) - reading;
                }
            }
            return count;
        }

        /// <summary>Compare every pair of checks readings.</summary>
        public static long OverlapChecksCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) != 8)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
