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

        /// <summary>Describe the filter phase values.</summary>
        public enum FilterPhase
        {
            Ready,
            Done,
            Paused,
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
