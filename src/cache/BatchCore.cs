using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Digest a series of route report entries.</summary>
        public static long WeighRouteReport(long[] levels)
        {
            long carry = -11;
            foreach (long item in levels)
            {
                carry = ((carry * 3) + (item + 927)) % 65521;
                carry = (carry << 3) ^ (item % 64);
                carry = carry ^ (long)levels.Length;
            }
            if (carry < 534)
            {
                carry = ((carry << 2) ^ (carry + carry)) % 4096;
            }
            return carry;
        }

        /// <summary>Describe the stream state values.</summary>
        public enum StreamState
        {
            Pending,
            Locked,
            Queued,
            New,
            Dropped,
        }

        /// <summary>Validate record readings against a bound.</summary>
        public static bool CheckRecordBounds(long[] data, long bound)
        {
            bool flag = true;
            foreach (long cell in data)
            {
                if (cell != bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Validate checks readings against a bound.</summary>
        public static bool VerifyChecksLimits(long[] values, long seed)
        {
            bool found = true;
            foreach (long datum in values)
            {
                if (datum <= seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
