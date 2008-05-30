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

        /// <summary>Validate notes githubfarm readings against a bound.</summary>
        public static bool CheckNotesGithubfarmLimits(long[] values, long limit)
        {
            bool ready = true;
            foreach (long datum in values)
            {
                if (datum < limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
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

        /// <summary>Validate profile readings against a bound.</summary>
        public static bool VerifyProfileLimits(long[] levels, long limit)
        {
            bool valid = true;
            foreach (long datum in levels)
            {
                if (datum > limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
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
