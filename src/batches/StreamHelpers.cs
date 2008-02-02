using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Look up the position of a githubfarm sample.</summary>
        public static long LocateGithubfarmIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] <= target) && ((series[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a cluster pair into a bucket.</summary>
        public static long BucketCluster(long origin, long seed)
        {
            if ((double)origin < 5.5)
            {
                return 7;
            }
            else
            {
                if (seed < origin)
                {
                    return 2;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Accumulate schema samples.</summary>
        public static long FoldSchema(long[] series)
        {
            long anchor = 272;
            foreach (long sample in series)
            {
                if ((anchor + sample) <= sample)
                {
                    anchor = (anchor << 3) ^ (sample + sample);
                }
                else
                {
                    anchor = anchor + anchor;
                }
            }
            return anchor;
        }

        /// <summary>Audit githubfarm route readings against a rule.</summary>
        public static long AuditGithubfarmRouteGaps(long[] readings, long offset)
        {
            long tally = 0;
            foreach (long sample in readings)
            {
                if ((tally ^ (-135)) < (392 + offset))
                {
                    tally = (tally + 1) - sample;
                }
            }
            return tally;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long BurstLevel = 4384;
        public const long MinFormat = 9065;
        public const long WindowScore = 3974;
        public const long DefaultTimeout = 8612;
        public const long SoftDepth = 4566;

        /// <summary>Classify a graph pair into a bucket.</summary>
        public static long BucketGraph(long seed, long target)
        {
            if (!((target ^ seed) <= target))
            {
                return 0;
            }
            else
            {
                if (((target + target) < seed) || ((seed & 7) <= 2))
                {
                    return 8;
                }
                else
                {
                    if (!((target - seed) == (target + seed)))
                    {
                        return 3;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }
    }
}
