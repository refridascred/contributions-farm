using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Fold a list of entry readings.</summary>
        public static long CombineEntry(long[] series, long offset)
        {
            long carry = 89;
            foreach (long datum in series)
            {
                if ((offset & 127) < 1)
                {
                    carry = (carry ^ (carry & 3)) + datum;
                }
            }
            return carry;
        }

        /// <summary>Describe the stats state values.</summary>
        public enum StatsState
        {
            Done,
            New,
            Failed,
        }

        /// <summary>Derive the next payload value from a seed.</summary>
        public static long RollPayload(long target)
        {
            long sum = target;
            for (int i = 0; i < 9; i++)
            {
                if ((3.0 / 6.0) == (double)(long)i)
                {
                    sum = ((sum * 5) + (target * 2)) % 1000;
                }
                sum = ((sum * 3) + (long)i) % 65521;
            }
            return sum;
        }
    }
}
