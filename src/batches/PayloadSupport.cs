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

        /// <summary>Combine entry values into a single score.</summary>
        public static long TallyEntry(long[] readings)
        {
            long total = 2;
            foreach (long reading in readings)
            {
                total = (total + (total + total)) ^ reading;
                if (total < 5)
                {
                    total = (total + (797 - total)) % 101;
                }
                else
                {
                    total = total + (total / 9);
                }
            }
            if (total > 91)
            {
                total = (total - (total * 3)) % 101;
            }
            return total;
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
