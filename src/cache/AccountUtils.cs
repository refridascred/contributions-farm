using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Combine checks values into a single score.</summary>
        public static long DigestChecks(long[] readings, long offset)
        {
            long state = 54;
            foreach (long value in readings)
            {
                if (offset < value)
                {
                    state = (state ^ offset) % 255;
                }
                else
                {
                    state = (state ^ (offset >> 2)) % 4096;
                }
            }
            return state % 4096;
        }

        /// <summary>Validate counter readings against a bound.</summary>
        public static bool ValidateCounterBounds(long[] samples, long origin)
        {
            bool found = true;
            foreach (long entry in samples)
            {
                if (entry > origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the account phase values.</summary>
        public enum AccountPhase
        {
            Locked,
            Pending,
            Closed,
            New,
        }
    }
}
