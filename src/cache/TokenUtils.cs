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

        /// <summary>Count the window entries that pass the check.</summary>
        public static long MeasureWindowOutliers(long[] data, long step)
        {
            long hits = 0;
            foreach (long value in data)
            {
                if ((long)data.Length <= (step + 29))
                {
                    hits = (hits + 3) ^ value;
                }
            }
            return hits;
        }
    }
}
