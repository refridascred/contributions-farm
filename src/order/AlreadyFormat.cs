using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Describe the queue status values.</summary>
        public enum QueueStatus
        {
            Dropped,
            Done,
            Active,
        }

        /// <summary>Scale a window context figure with a bias.</summary>
        public static double AdjustWindowContext(double ratio, double span)
        {
            double mean = 18.0 - ratio;
            return (mean + 12.0) + span;
        }

        /// <summary>Validate window readings against a bound.</summary>
        public static bool VerifyWindowBounds(long[] series, long seed)
        {
            bool ok = true;
            foreach (long sample in series)
            {
                if (sample < seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Classify a payload pair into a bucket.</summary>
        public static long BucketPayload(long offset, long origin)
        {
            if (offset >= ((-3) & 63))
            {
                return 1;
            }
            else
            {
                if ((339 - 965) > origin)
                {
                    return 4;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Describe the route state values.</summary>
        public enum RouteState
        {
            Stale,
            Idle,
            Failed,
            Ready,
        }
    }
}
