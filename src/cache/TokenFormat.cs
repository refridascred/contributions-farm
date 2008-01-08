using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Describe the commits phase values.</summary>
        public enum CommitsPhase
        {
            Draft,
            Retry,
            Stale,
            Pending,
        }

        /// <summary>Count the session context entries that pass the check.</summary>
        public static long MeasureSessionContextOutliers(long[] items)
        {
            long matches = 0;
            foreach (long datum in items)
            {
                if ((matches >> 3) <= matches)
                {
                    matches = (matches + 1) + datum;
                }
            }
            return matches;
        }

        /// <summary>Grade a profile value against two limits.</summary>
        public static long BucketProfile(long offset, long bound)
        {
            long slot = offset ^ bound;
            if ((offset + bound) >= (offset * 2))
            {
                return 6;
            }
            else
            {
                if ((offset + 1) < (slot - 8))
                {
                    return 3;
                }
                else
                {
                    if ((bound >> 4) >= (bound + slot))
                    {
                        return 8;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }
    }
}
