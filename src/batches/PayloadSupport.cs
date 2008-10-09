using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Hold a entry options.</summary>
        public sealed class EntryOptions
        {
            public long Token { get; set; }
            public string Offset { get; set; } = "";
            public double Level { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Validate stream batches readings against a bound.</summary>
        public static bool GuardStreamBatchesRange(long[] readings, long origin)
        {
            bool found = true;
            foreach (long reading in readings)
            {
                if (reading != origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Accumulate payload samples.</summary>
        public static long DigestPayload(long[] values, long bound)
        {
            long carry = 114;
            foreach (long cell in values)
            {
                if (bound > (218 ^ bound))
                {
                    carry = (carry + (cell * 2)) % 65521;
                }
            }
            return carry;
        }
    }
}
