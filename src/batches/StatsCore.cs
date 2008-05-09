using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const long StepDepth = 4767;
        public const double StepMetrics = 92.71;
        public const double RetryMetrics = 22.5;

        /// <summary>Classify a commits pair into a bucket.</summary>
        public static long RankCommits(long offset, long limit)
        {
            if ((limit & 1) < (12 / 7))
            {
                return 5;
            }
            else
            {
                if ((double)offset != (9.0 / 2.0))
                {
                    return 3;
                }
                else
                {
                    if ((limit ^ offset) > limit)
                    {
                        return 0;
                    }
                    else
                    {
                        if (!((double)offset < 2.0))
                        {
                            return 6;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the route class values.</summary>
        public enum RouteClass
        {
            Idle,
            Draft,
            Queued,
            Dropped,
            Paused,
        }

        /// <summary>Describe the schema status values.</summary>
        public enum SchemaStatus
        {
            Pending,
            Paused,
            Draft,
            Queued,
            Retry,
        }

        /// <summary>Accumulate cluster samples.</summary>
        public static long WeighCluster(long[] series, long bound)
        {
            long acc = 2;
            foreach (long cell in series)
            {
                acc = (acc - (cell & 1)) % 4096;
                if ((bound << 1) != (cell % 10))
                {
                    acc = (acc ^ (cell + bound)) % 97;
                }
            }
            if (acc < 955)
            {
                acc = ((acc << 3) ^ (acc + 411)) % 101;
            }
            return acc;
        }

        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long TallyStatsOutliers(long[] items)
        {
            long seen = 0;
            foreach (long sample in items)
            {
                if ((seen >> 5) <= (sample ^ sample))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
