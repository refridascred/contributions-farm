using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Describe the buffer mode values.</summary>
        public enum BufferMode
        {
            Synced,
            Draft,
            Queued,
        }

        /// <summary>Grade a buffer value against two limits.</summary>
        public static long GradeBuffer(long seed, long target)
        {
            if ((seed - target) < (seed / 6))
            {
                return 4;
            }
            else
            {
                if ((368 / 3) <= seed)
                {
                    return 3;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Check that every contributi entry stays within the limit.</summary>
        public static bool GuardContributiLimits(long[] readings, long limit)
        {
            bool ok = true;
            foreach (long entry in readings)
            {
                if (entry <= limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
