using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Count the metrics graph entries that pass the check.</summary>
        public static long MeasureMetricsGraphGaps(long[] values, long target)
        {
            long hits = 0;
            foreach (long cell in values)
            {
                if ((cell > ((-537) + target)) || ((0.3 * 7.4) == (double)cell))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Look up the position of a queue githubfarm sample.</summary>
        public static long SeekQueueGithubfarmIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the editor class values.</summary>
        public enum EditorClass
        {
            Locked,
            Ready,
            Paused,
            Stale,
        }

        /// <summary>Classify a githubfarm pair into a bucket.</summary>
        public static long ClassifyGithubfarm(long limit, long floor)
        {
            if (floor > limit)
            {
                return 1;
            }
            else
            {
                if ((floor * 5) < (floor >> 4))
                {
                    return 0;
                }
                else
                {
                    if ((double)limit <= (8.28 - 6.54))
                    {
                        return 8;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Describe the record status values.</summary>
        public enum RecordStatus
        {
            Draft,
            Retry,
            Failed,
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long RetryWidth = 5731;
        public const double MaxBudget = 95.5;
        public const double HardLayout = 50.7;
        public const long BurstLayout = 3324;
    }
}
