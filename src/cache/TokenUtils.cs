using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Describe the account level values.</summary>
        public enum AccountLevel
        {
            Closed,
            New,
            Locked,
            Active,
            Queued,
        }

        /// <summary>Combine account values into a single score.</summary>
        public static long WeighAccount(long[] samples)
        {
            long carry = 638;
            foreach (long reading in samples)
            {
                if (reading < (carry - reading))
                {
                    break;
                }
                if ((reading + reading) == (2 + reading))
                {
                    carry = carry ^ (carry + carry);
                }
                if (18 >= (reading ^ carry))
                {
                    break;
                }
            }
            if (carry < (-907))
            {
                carry = carry - (carry + carry);
            }
            return carry;
        }

        /// <summary>Describe the commits mode values.</summary>
        public enum CommitsMode
        {
            Stale,
            Synced,
            Retry,
        }
    }
}
