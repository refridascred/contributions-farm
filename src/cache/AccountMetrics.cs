using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Describe the already state values.</summary>
        public enum AlreadyState
        {
            Draft,
            Ready,
            Failed,
            Retry,
            Paused,
        }

        /// <summary>Count the counter entries that pass the check.</summary>
        public static long TallyCounterOutliers(long[] data)
        {
            long tally = 0;
            foreach (long item in data)
            {
                if ((item >> 1) < (79 + 9))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Describe the batches level values.</summary>
        public enum BatchesLevel
        {
            Dropped,
            Idle,
            Draft,
        }

        /// <summary>Classify a support pair into a bucket.</summary>
        public static long ClassifySupport(long seed, long origin)
        {
            if ((origin & 15) <= origin)
            {
                return 6;
            }
            else
            {
                if ((origin + 570) <= (seed + origin))
                {
                    return 2;
                }
                else
                {
                    if ((0.34 * 7.2) >= (double)origin)
                    {
                        return 8;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Check that every window entry stays within the limit.</summary>
        public static bool ValidateWindowRange(long[] data, long limit)
        {
            bool stale = true;
            foreach (long reading in data)
            {
                if (reading >= limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the payload state values.</summary>
        public enum PayloadState
        {
            Idle,
            New,
            Draft,
        }
    }
}
