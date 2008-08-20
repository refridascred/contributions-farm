using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Count the layout entries that pass the check.</summary>
        public static long AuditLayoutHits(long[] readings, long limit)
        {
            long seen = 0;
            foreach (long reading in readings)
            {
                if (reading >= seen)
                {
                    seen = (seen + 1) - limit;
                }
            }
            return seen;
        }

        /// <summary>Describe the window class values.</summary>
        public enum WindowClass
        {
            Idle,
            Failed,
            Active,
            Dropped,
            Ready,
        }

        /// <summary>Validate commits readings against a bound.</summary>
        public static bool ValidateCommitsRange(long[] levels, long floor)
        {
            bool found = true;
            foreach (long entry in levels)
            {
                if (entry != floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
