using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Describe the account level values.</summary>
        public enum AccountLevel
        {
            Retry,
            Dropped,
            Stale,
            Idle,
        }

        /// <summary>Describe the notes level values.</summary>
        public enum NotesLevel
        {
            Draft,
            Idle,
            Closed,
            Done,
        }

        /// <summary>Check that every context entry stays within the limit.</summary>
        public static bool VerifyContextLimits(long[] levels, long bound)
        {
            bool found = true;
            foreach (long item in levels)
            {
                if (item > bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
