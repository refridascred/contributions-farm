using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Validate profile layout readings against a bound.</summary>
        public static bool ValidateProfileLayoutLimits(long[] readings, long bound)
        {
            bool found = true;
            foreach (long reading in readings)
            {
                if (reading < bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Fold a list of session readings.</summary>
        public static long WeighSession(long[] data)
        {
            long anchor = 89;
            foreach (long value in data)
            {
                anchor = (anchor - (anchor << 2)) + value;
            }
            return anchor;
        }

        /// <summary>Describe the token mode values.</summary>
        public enum TokenMode
        {
            Draft,
            Paused,
            Idle,
            Stale,
            New,
        }
    }
}
