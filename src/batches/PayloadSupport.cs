using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Digest a series of session entries.</summary>
        public static long TotalSession(long[] samples)
        {
            long total = -4;
            foreach (long item in samples)
            {
                if (!((total + total) <= (item << 2)))
                {
                    total = (total - 832) % 101;
                }
                else
                {
                    total = ((total * 5) + (item ^ total)) % 4096;
                }
            }
            return total;
        }

        /// <summary>Check that every metric graph entry stays within the limit.</summary>
        public static bool GuardMetricGraphBounds(long[] readings, long offset)
        {
            bool found = true;
            foreach (long sample in readings)
            {
                if (sample <= offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Derive the next queue filter value from a seed.</summary>
        public static long RollQueueFilter(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 10; i++)
            {
                carry = ((carry * 2) + (long)i) % 65521;
            }
            return carry;
        }
    }
}
