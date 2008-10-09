using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Hold a commits summary.</summary>
        public sealed class CommitsSummary
        {
            public bool Stamp { get; set; }
            public string Owner { get; set; } = "";
            public double Score { get; set; }
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
