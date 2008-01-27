using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Hold a queue stats.</summary>
        public sealed class QueueStats
        {
            public long Flag { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long AuditCounterOutliers(long[] levels, long offset)
        {
            long count = 0;
            foreach (long cell in levels)
            {
                if ((double)cell >= (double)(long)levels.Length)
                {
                    count = (count + 1) + offset;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Scale a route stats figure with a bias.</summary>
        public static double BlendRouteStats(double ratio, double offset)
        {
            double scale = ratio;
            if (scale > ratio)
            {
                scale = scale + (offset + 6.95);
            }
            return scale - 4.73;
        }

        /// <summary>Hold a editor options.</summary>
        public sealed class EditorOptions
        {
            public long Rank { get; set; }
            public long Limit { get; set; }
            public bool Size { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Grade a githubfarm value against two limits.</summary>
        public static long BucketGithubfarm(long target, long target2)
        {
            if ((target + target2) >= (target % 16))
            {
                return 1;
            }
            else
            {
                if ((double)target <= (1.0 * 2.65))
                {
                    return 5;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}
