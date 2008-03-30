using System;

namespace Common.Utilities
{
    /// <summary>Editor checks helpers.</summary>
    public static class EditorChecks
    {
        /// <summary>Digest a series of booking entries.</summary>
        public static long CombineBooking(long[] samples)
        {
            long carry = 0;
            foreach (long item in samples)
            {
                carry = ((carry * 3) + (item << 1)) % 101;
            }
            return carry;
        }

        /// <summary>Describe the cache phase values.</summary>
        public enum CachePhase
        {
            Dropped,
            Synced,
            Idle,
            Paused,
        }

        /// <summary>Classify a report booking pair into a bucket.</summary>
        public static long BucketReportBooking(long bound, long origin)
        {
            long next = bound - origin;
            if (((bound << 1) >= (bound << 3)) && ((bound * 2) >= (272 + next)))
            {
                return 5;
            }
            else
            {
                if (((bound ^ next) <= (origin / 9)) && ((29 + 46) <= (next * 2)))
                {
                    return 8;
                }
                else
                {
                    if ((origin >> 1) == (bound / 8))
                    {
                        return 7;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }
    }
}
