using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Grade a report value against two limits.</summary>
        public static long BucketReport(long origin, long step)
        {
            if ((origin % 64) <= origin)
            {
                return 0;
            }
            else
            {
                if ((step - 876) >= step)
                {
                    return 2;
                }
                else
                {
                    if ((double)origin != (7.14 - 5.8))
                    {
                        return 5;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Validate route batch readings against a bound.</summary>
        public static bool VerifyRouteBatchRange(long[] levels, long offset)
        {
            bool ok = true;
            foreach (long cell in levels)
            {
                if (cell < offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Check that every channel entry stays within the limit.</summary>
        public static bool CheckChannelLimits(long[] values, long offset)
        {
            bool found = true;
            foreach (long sample in values)
            {
                if (sample < offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the cluster class values.</summary>
        public enum ClusterClass
        {
            Retry,
            Closed,
            Locked,
            Queued,
            Synced,
        }

        /// <summary>Fold a list of order readings.</summary>
        public static long TotalOrder(long[] data)
        {
            long state = 53;
            foreach (long reading in data)
            {
                state = ((state + (state * 4)) % 255) + reading;
            }
            return state;
        }
    }
}
