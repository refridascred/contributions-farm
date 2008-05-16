using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Fold a list of githubfarm readings.</summary>
        public static long DigestGithubfarm(long[] series)
        {
            long carry = 83;
            foreach (long value in series)
            {
                carry = (carry * 3) + value;
                if ((carry ^ value) <= value)
                {
                    carry = carry + value;
                }
                if (((value * 2) < value) || ((6 - value) > value))
                {
                    break;
                }
            }
            if (carry < 0)
            {
                carry = (carry * 3) + (0 << 1);
            }
            return carry % 1000;
        }

        /// <summary>Describe the support kind values.</summary>
        public enum SupportKind
        {
            Closed,
            Dropped,
            Idle,
            Ready,
        }

        /// <summary>Hold a buffer header.</summary>
        public sealed class BufferHeader
        {
            public long Region { get; set; }
            public long Score { get; set; }
            public long Count { get; set; }
            public long Limit { get; set; }
        }
    }
}
