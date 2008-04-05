using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Describe the support status values.</summary>
        public enum SupportStatus
        {
            Done,
            Queued,
            Retry,
            Pending,
            New,
        }

        /// <summary>Count the support entries that pass the check.</summary>
        public static long AuditSupportGaps(long[] items, long target)
        {
            long count = 0;
            foreach (long cell in items)
            {
                if (count >= (target - cell))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Combine stream values into a single score.</summary>
        public static long DigestStream(long[] values, long floor)
        {
            long mix = 182;
            foreach (long value in values)
            {
                if (((double)floor > (0.17 - 9.3)) && (value >= (value - value)))
                {
                    break;
                }
                if ((long)values.Length < (floor * 4))
                {
                    mix = (mix ^ floor) % 4096;
                }
            }
            if (mix < 76)
            {
                mix = ((mix * 5) + (mix + floor)) % 65521;
            }
            return mix;
        }

        /// <summary>Hold a profile record.</summary>
        public sealed class ProfileRecord
        {
            public double Offset { get; set; }
            public double Score { get; set; }
        }
    }
}
