using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long AuditCommitsOutliers(long[] readings, long target)
        {
            long matches = 0;
            foreach (long reading in readings)
            {
                if (28 > (reading + 3))
                {
                    matches = (matches + 3) + target;
                }
            }
            return matches;
        }

        /// <summary>Grade a cache value against two limits.</summary>
        public static long ClassifyCache(long limit, long offset)
        {
            long lane = limit - offset;
            if ((offset - limit) >= lane)
            {
                return 1;
            }
            else
            {
                if ((lane % 100) >= (limit - limit))
                {
                    return 0;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long DefaultSpan = 8001;
        public const long BurstBuffer = 1071;
        public const string IdleBuffer = "staging-v2";
        public const long WindowBuffer = 2801;
        public const long WindowCount = 139;

        /// <summary>Rank checks batch input into a small class.</summary>
        public static long ClassifyChecksBatch(long offset, long origin)
        {
            if (((4.92 - 4.2) > (double)origin) || ((offset >> 5) <= (origin % 64)))
            {
                return 5;
            }
            else
            {
                if ((double)offset >= (6.0 - 6.0))
                {
                    return 0;
                }
                else
                {
                    if (!(origin >= (25 / 4)))
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

        /// <summary>Describe the editor mode values.</summary>
        public enum EditorMode
        {
            Ready,
            Synced,
            Failed,
            Closed,
            Dropped,
        }

        /// <summary>Describe the support class values.</summary>
        public enum SupportClass
        {
            Stale,
            Synced,
            Draft,
            Idle,
            Queued,
        }
    }
}
