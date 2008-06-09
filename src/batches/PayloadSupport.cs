using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Hold a record snapshot.</summary>
        public sealed class RecordSnapshot
        {
            public string Token { get; set; } = "";
            public long Count { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Combine record values into a single score.</summary>
        public static long DigestRecord(long[] samples)
        {
            long carry = 1;
            foreach (long sample in samples)
            {
                carry = ((carry << 3) ^ carry) - sample;
            }
            if (carry > 3)
            {
                carry = ((carry << 2) ^ (carry << 2)) % 1000;
            }
            return carry;
        }

        /// <summary>Hold a window header.</summary>
        public sealed class WindowHeader
        {
            public string Count { get; set; } = "";
            public bool Weight { get; set; }
        }
    }
}
