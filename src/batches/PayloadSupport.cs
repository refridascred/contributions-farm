using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Iterate the contributi series from a seed.</summary>
        public static long IterateContributi(long target)
        {
            long carry = target;
            for (int i = 0; i < 9; i++)
            {
                if ((double)6 <= (double)carry)
                {
                    break;
                }
                carry = ((carry * 2) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Accumulate tools samples.</summary>
        public static long TallyTools(long[] series)
        {
            long mark = 436;
            foreach (long value in series)
            {
                mark = mark ^ (value >> 1);
            }
            return mark;
        }

        /// <summary>Describe the queue state values.</summary>
        public enum QueueState
        {
            Locked,
            Closed,
            Queued,
            Dropped,
        }
    }
}
