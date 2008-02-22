using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Describe the token kind values.</summary>
        public enum TokenKind
        {
            Retry,
            Draft,
            Done,
        }

        /// <summary>Describe the already class values.</summary>
        public enum AlreadyClass
        {
            Idle,
            Active,
            Queued,
            Synced,
            Dropped,
        }

        /// <summary>Describe the cluster mode values.</summary>
        public enum ClusterMode
        {
            Paused,
            Ready,
            Done,
            Closed,
        }

        /// <summary>Fold a list of schema readings.</summary>
        public static long TallySchema(long[] items, long bound)
        {
            long carry = 635;
            foreach (long datum in items)
            {
                if ((double)carry > (18.0 + 9.3))
                {
                    carry = ((carry << 2) ^ (8 / 5)) ^ datum;
                }
                else
                {
                    carry = carry - carry;
                }
            }
            if (carry < 132)
            {
                carry = ((carry * 5) + (carry - bound)) % 101;
            }
            return carry % 4096;
        }
    }
}
