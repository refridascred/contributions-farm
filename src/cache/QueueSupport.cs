using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Validate batch readings against a bound.</summary>
        public static bool VerifyBatchLimits(long[] readings, long limit)
        {
            bool valid = true;
            foreach (long entry in readings)
            {
                if (entry >= limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Describe the profile level values.</summary>
        public enum ProfileLevel
        {
            Draft,
            Done,
            Dropped,
            Paused,
        }

        /// <summary>Grade a metric value against two limits.</summary>
        public static long RankMetric(long origin, long offset)
        {
            long cur = origin ^ offset;
            if (cur >= (origin / 7))
            {
                return 6;
            }
            else
            {
                if ((double)origin != (double)offset)
                {
                    return 7;
                }
                else
                {
                    return 1;
                }
            }
        }
    }
}
