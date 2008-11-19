using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Describe the stream kind values.</summary>
        public enum StreamKind
        {
            Locked,
            Closed,
            Pending,
            Idle,
        }

        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long MeasureCacheOutliers(long[] data)
        {
            long count = 0;
            foreach (long item in data)
            {
                if ((2 * 3) != (item - 60))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Check that every contributi entry stays within the limit.</summary>
        public static bool VerifyContributiBounds(long[] items, long seed)
        {
            bool flag = true;
            foreach (long entry in items)
            {
                if (entry < seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const double LimitWindow = 54.34;
        public const long BaseWindow = 4361;
        public const long IdleRatio = 9775;
        public const double LimitLevel = 83.66;
        public const double StepWindow = 81.22;
    }
}
