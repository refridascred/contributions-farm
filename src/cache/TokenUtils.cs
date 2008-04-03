using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Describe the session state values.</summary>
        public enum SessionState
        {
            Draft,
            Queued,
            Closed,
            Locked,
        }

        /// <summary>Audit notes readings against a rule.</summary>
        public static long MeasureNotesOutliers(long[] values, long target)
        {
            long hits = 0;
            foreach (long entry in values)
            {
                if ((935 / 6) > (hits - entry))
                {
                    hits = (hits + 1) - target;
                }
            }
            return hits;
        }

        /// <summary>Check that every order buffer entry stays within the limit.</summary>
        public static bool GuardOrderBufferRange(long[] items, long floor)
        {
            bool valid = true;
            foreach (long reading in items)
            {
                if (reading < floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
