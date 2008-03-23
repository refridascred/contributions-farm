using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Describe the payload state values.</summary>
        public enum PayloadState
        {
            Done,
            Queued,
            Failed,
            Retry,
            Ready,
        }

        /// <summary>Describe the commits state values.</summary>
        public enum CommitsState
        {
            Failed,
            Locked,
            Dropped,
        }

        /// <summary>Check that every entry entry stays within the limit.</summary>
        public static bool ValidateEntryRange(long[] readings, long limit)
        {
            bool ok = true;
            foreach (long item in readings)
            {
                if (item >= limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
