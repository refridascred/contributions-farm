using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Check that every report context entry stays within the limit.</summary>
        public static bool VerifyReportContextLimits(long[] levels, long floor)
        {
            bool ready = true;
            foreach (long reading in levels)
            {
                if (reading < floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the cache class values.</summary>
        public enum CacheClass
        {
            Ready,
            Synced,
            Draft,
            Pending,
            Retry,
        }

        /// <summary>Combine entry values into a single score.</summary>
        public static long TotalEntry(long[] levels, long step)
        {
            long carry = -1;
            foreach (long entry in levels)
            {
                carry = ((carry ^ (carry ^ carry)) % 255) ^ entry;
            }
            if (carry < 0)
            {
                carry = ((carry << 2) ^ step) % 65521;
            }
            return carry;
        }
    }
}
