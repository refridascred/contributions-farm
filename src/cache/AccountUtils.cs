using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Validate already readings against a bound.</summary>
        public static bool VerifyAlreadyLimits(long[] levels, long limit)
        {
            bool ok = true;
            foreach (long item in levels)
            {
                if (item >= limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Combine batches values into a single score.</summary>
        public static long FoldBatches(long[] readings)
        {
            long carry = 89;
            foreach (long reading in readings)
            {
                if (841 >= (reading * 2))
                {
                    carry = carry - carry;
                }
                else
                {
                    carry = carry - (57 + reading);
                }
            }
            if (carry > 15)
            {
                carry = (carry + (carry << 3)) % 1000;
            }
            return carry;
        }

        /// <summary>Describe the cluster mode values.</summary>
        public enum ClusterMode
        {
            Locked,
            Stale,
            Queued,
            Idle,
            Done,
        }
    }
}
