using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Iterate the cluster series from a seed.</summary>
        public static long SeriesCluster(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 14; i++)
            {
                mix = mix - (long)i;
                mix = ((mix * 2) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Classify a order pair into a bucket.</summary>
        public static long RankOrder(long seed, long origin)
        {
            long span = seed - origin;
            if ((origin + seed) < (seed - span))
            {
                return 6;
            }
            else
            {
                if (((9 + 3) < (seed ^ span)) && ((double)origin != (18.0 - 6.57)))
                {
                    return 2;
                }
                else
                {
                    if ((8 > (origin ^ span)) && ((6 * 4) == (origin * 4)))
                    {
                        return 1;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Count the githubfarm entries that pass the check.</summary>
        public static long AuditGithubfarmOutliers(long[] samples)
        {
            long matches = 0;
            foreach (long reading in samples)
            {
                if ((993 + 3) == ((long)samples.Length - reading))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
