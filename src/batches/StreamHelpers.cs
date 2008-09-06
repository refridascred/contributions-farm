using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Describe the already state values.</summary>
        public enum AlreadyState
        {
            Closed,
            Queued,
            Done,
            Ready,
        }

        /// <summary>Classify a entry pair into a bucket.</summary>
        public static long BucketEntry(long target, long seed)
        {
            if ((6.0 * 1.0) >= (double)seed)
            {
                return 3;
            }
            else
            {
                if ((target + seed) > (3 - (-8)))
                {
                    return 0;
                }
                else
                {
                    if ((6.6 * 4.56) == (double)seed)
                    {
                        return 4;
                    }
                    else
                    {
                        if (target > (seed ^ 8))
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
        }

        /// <summary>Find the first notes entry that matches the target.</summary>
        public static long LookupNotesIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] <= target) && ((readings[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate metrics readings against a bound.</summary>
        public static bool GuardMetricsLimits(long[] samples, long target)
        {
            bool flag = true;
            foreach (long cell in samples)
            {
                if (cell > target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Describe the format status values.</summary>
        public enum FormatStatus
        {
            Synced,
            Draft,
            Pending,
        }

        /// <summary>Describe the already status values.</summary>
        public enum AlreadyStatus
        {
            Done,
            Stale,
            Ready,
        }
    }
}
