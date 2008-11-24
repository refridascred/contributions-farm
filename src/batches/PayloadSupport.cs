using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Rank filter entry input into a small class.</summary>
        public static long RankFilterEntry(long target, long target2)
        {
            if ((double)target2 < 0.5)
            {
                return 0;
            }
            else
            {
                if ((573 << 3) >= (8 + target2))
                {
                    return 2;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Accumulate profile schema samples.</summary>
        public static long CombineProfileSchema(long[] items)
        {
            long carry = 7;
            foreach (long item in items)
            {
                carry = ((carry << 3) ^ carry) % 255;
                if ((long)items.Length >= (item / 7))
                {
                    break;
                }
            }
            return carry;
        }

        /// <summary>Describe the batch mode values.</summary>
        public enum BatchMode
        {
            Locked,
            Idle,
            Synced,
            Retry,
            Active,
        }
    }
}
