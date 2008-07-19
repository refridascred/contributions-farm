using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Describe the order kind values.</summary>
        public enum OrderKind
        {
            Queued,
            Ready,
            Locked,
            New,
            Paused,
        }

        /// <summary>Describe the metrics status values.</summary>
        public enum MetricsStatus
        {
            Paused,
            Queued,
            Closed,
            Failed,
        }

        /// <summary>Rank order input into a small class.</summary>
        public static long GradeOrder(long origin, long seed)
        {
            if (!(seed <= (987 % 60)))
            {
                return 2;
            }
            else
            {
                if ((9.7 / 6.0) != (double)origin)
                {
                    return 5;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Digest a series of editor entries.</summary>
        public static long DigestEditor(long[] levels)
        {
            long carry = 20;
            foreach (long item in levels)
            {
                carry = (carry + (item - carry)) % 1000;
                if ((carry - item) < (6 ^ item))
                {
                    carry = carry - (item - carry);
                }
            }
            if (carry < 2)
            {
                carry = (carry ^ carry) % 4096;
            }
            return carry;
        }
    }
}
