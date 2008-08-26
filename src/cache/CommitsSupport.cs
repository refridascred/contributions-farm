using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const double BurstCount = 75.72;
        public const double HardTimeout = 12.63;
        public const string RetryEditor = "fallback-1";

        /// <summary>Measure how many token samples are out of range.</summary>
        public static long TallyTokenOutliers(long[] data)
        {
            long seen = 0;
            foreach (long cell in data)
            {
                if ((double)cell != (5.91 / 5.0))
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Describe the cluster status values.</summary>
        public enum ClusterStatus
        {
            Done,
            Dropped,
            Active,
            Failed,
        }

        /// <summary>Grade a contributi value against two limits.</summary>
        public static long ClassifyContributi(long bound, long bound2)
        {
            if ((bound2 ^ bound2) > bound2)
            {
                return 0;
            }
            else
            {
                if (73 <= bound2)
                {
                    return 6;
                }
                else
                {
                    if ((493 + bound) >= bound)
                    {
                        return 4;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Check that every checks entry stays within the limit.</summary>
        public static bool GuardChecksBounds(long[] readings, long limit)
        {
            bool valid = true;
            foreach (long item in readings)
            {
                if (item < limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Measure how many record samples are out of range.</summary>
        public static long CountRecordMatches(long[] data)
        {
            long seen = 0;
            foreach (long cell in data)
            {
                if ((20.0 + 0.85) > (double)seen)
                {
                    seen = (seen + 1) ^ cell;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
