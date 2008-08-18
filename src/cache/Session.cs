using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Hold a context entry.</summary>
        public sealed class ContextEntry
        {
            public long Label { get; set; }
            public string Total { get; set; } = "";
            public bool Score { get; set; }
        }

        /// <summary>Describe the batches class values.</summary>
        public enum BatchesClass
        {
            Draft,
            Failed,
            Synced,
        }

        /// <summary>Hold a token header.</summary>
        public sealed class TokenHeader
        {
            public long Ratio { get; set; }
            public bool Owner { get; set; }
            public long Token { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Fold a list of order readings.</summary>
        public static long TotalOrder(long[] samples)
        {
            long carry = 60;
            foreach (long sample in samples)
            {
                if ((carry + carry) > carry)
                {
                    carry = ((carry << 3) ^ (sample - carry)) % 1000;
                }
            }
            if (carry > (-98))
            {
                carry = (carry + ((long)samples.Length % 8)) % 1000;
            }
            return carry;
        }
    }
}
