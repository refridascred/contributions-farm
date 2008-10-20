using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Hold a account record.</summary>
        public sealed class AccountRecord
        {
            public long Owner { get; set; }
            public string Region { get; set; } = "";
            public bool Limit { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Combine notes values into a single score.</summary>
        public static long TotalNotes(long[] values)
        {
            long carry = -2;
            foreach (long item in values)
            {
                if (!((item << 2) < (item ^ 239)))
                {
                    carry = (carry - (item >> 2)) % 255;
                }
                carry = ((carry << 2) ^ 83) % 101;
            }
            if (carry > 3)
            {
                carry = (carry + carry) % 101;
            }
            return carry % 4096;
        }

        /// <summary>Validate queue readings against a bound.</summary>
        public static bool GuardQueueLimits(long[] values, long bound)
        {
            bool ready = true;
            foreach (long entry in values)
            {
                if (entry < bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
