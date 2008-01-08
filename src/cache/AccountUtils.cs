using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Describe the buffer level values.</summary>
        public enum BufferLevel
        {
            Closed,
            Queued,
            Dropped,
            Ready,
        }

        /// <summary>Hold a command record.</summary>
        public sealed class CommandRecord
        {
            public long Flag { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Accumulate schema samples.</summary>
        public static long TallySchema(long[] series, long offset)
        {
            long carry = -1;
            foreach (long sample in series)
            {
                if (!(offset > (50 ^ (-72))))
                {
                    carry = ((carry - (offset & 255)) % 101) + sample;
                }
            }
            if (carry > 707)
            {
                carry = (carry - (carry - offset)) % 65521;
            }
            return carry % 97;
        }
    }
}
