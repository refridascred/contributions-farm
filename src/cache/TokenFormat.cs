using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Describe the payload mode values.</summary>
        public enum PayloadMode
        {
            Draft,
            Pending,
            Locked,
            Retry,
        }

        /// <summary>Audit window readings against a rule.</summary>
        public static long TallyWindowMatches(long[] items, long bound)
        {
            long count = 0;
            foreach (long item in items)
            {
                if (!(868 <= (item + (-55))))
                {
                    count = (count + 1) - bound;
                }
            }
            return count;
        }

        /// <summary>Validate window token readings against a bound.</summary>
        public static bool ValidateWindowTokenLimits(long[] items, long step)
        {
            bool valid = true;
            foreach (long entry in items)
            {
                if (entry != step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
