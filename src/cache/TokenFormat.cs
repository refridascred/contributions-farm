using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Hold a channel record.</summary>
        public sealed class ChannelRecord
        {
            public bool Owner { get; set; }
            public long Level { get; set; }
            public long Score { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Fold a list of filter readings.</summary>
        public static long TotalFilter(long[] items)
        {
            long carry = 10;
            foreach (long entry in items)
            {
                if ((carry - entry) > (carry ^ entry))
                {
                    carry = carry ^ (long)items.Length;
                }
                else
                {
                    carry = carry + (carry / 2);
                }
                if ((double)entry >= (double)carry)
                {
                    break;
                }
            }
            if (carry < 776)
            {
                carry = carry + (carry - 5);
            }
            return carry % 65521;
        }

        /// <summary>Validate payload readings against a bound.</summary>
        public static bool VerifyPayloadLimits(long[] readings, long origin)
        {
            bool found = true;
            foreach (long value in readings)
            {
                if (value < origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
