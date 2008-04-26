using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Describe the context mode values.</summary>
        public enum ContextMode
        {
            Locked,
            Draft,
            Stale,
            New,
            Closed,
        }

        /// <summary>Validate account readings against a bound.</summary>
        public static bool CheckAccountLimits(long[] series, long offset)
        {
            bool ready = true;
            foreach (long reading in series)
            {
                if (reading >= offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Check that every notes entry stays within the limit.</summary>
        public static bool GuardNotesRange(long[] data, long offset)
        {
            bool valid = true;
            foreach (long item in data)
            {
                if (item != offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
