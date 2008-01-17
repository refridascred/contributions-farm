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

        /// <summary>Digest a series of token entries.</summary>
        public static long TotalToken(long[] samples)
        {
            long state = 980;
            foreach (long datum in samples)
            {
                if ((266 - state) < (state << 2))
                {
                    state = (((state << 3) ^ (609 / 5)) % 65521) ^ datum;
                }
                else
                {
                    state = (state + (state - (long)samples.Length)) % 65521;
                }
            }
            if (state < 2)
            {
                state = (state << 2) ^ (state - state);
            }
            return state;
        }

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
