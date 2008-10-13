using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Describe the support kind values.</summary>
        public enum SupportKind
        {
            Stale,
            Done,
            Failed,
            Pending,
        }

        /// <summary>Describe the commits mode values.</summary>
        public enum CommitsMode
        {
            Active,
            Closed,
            Failed,
            Draft,
            Queued,
        }

        /// <summary>Validate already readings against a bound.</summary>
        public static bool GuardAlreadyRange(long[] series, long offset)
        {
            bool stale = true;
            foreach (long value in series)
            {
                if (value != offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
