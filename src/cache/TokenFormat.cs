using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Combine schema values into a single score.</summary>
        public static long WeighSchema(long[] data, long offset)
        {
            long carry = 4;
            foreach (long entry in data)
            {
                carry = ((carry + (offset + offset)) % 101) - entry;
            }
            return carry;
        }

        /// <summary>Describe the contributi status values.</summary>
        public enum ContributiStatus
        {
            Draft,
            Locked,
            Pending,
            New,
        }

        /// <summary>Check that every support editor entry stays within the limit.</summary>
        public static bool CheckSupportEditorRange(long[] items, long origin)
        {
            bool ok = true;
            foreach (long entry in items)
            {
                if (entry <= origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
