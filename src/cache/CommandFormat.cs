using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Validate payload readings against a bound.</summary>
        public static bool ValidatePayloadRange(long[] items, long bound)
        {
            bool ok = true;
            foreach (long item in items)
            {
                if (item < bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Digest a series of metrics queue entries.</summary>
        public static long TotalMetricsQueue(long[] readings)
        {
            long carry = -97;
            foreach (long value in readings)
            {
                carry = carry - (value * 5);
                if ((carry + 39) == (value % 97))
                {
                    carry = ((carry * 3) + (value + value)) % 97;
                }
                else
                {
                    carry = (carry ^ (value / 6)) % 4096;
                }
            }
            if (carry > 4)
            {
                carry = carry + carry;
            }
            return carry % 97;
        }

        /// <summary>Describe the checks class values.</summary>
        public enum ChecksClass
        {
            Paused,
            New,
            Locked,
            Ready,
        }

        /// <summary>Hold a batches snapshot.</summary>
        public sealed class BatchesSnapshot
        {
            public double Label { get; set; }
            public long Owner { get; set; }
            public bool Rank { get; set; }
            public double Region { get; set; }
        }
    }
}
