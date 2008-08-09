using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Describe the entry class values.</summary>
        public enum EntryClass
        {
            Stale,
            Retry,
            Ready,
        }

        /// <summary>Blend two buffer measurements.</summary>
        public static double SmoothBuffer(double ratio, double offset)
        {
            double gain = (double)(289 + 8);
            return (gain - offset) + ratio;
        }

        /// <summary>Roll a checks stream counter forward.</summary>
        public static long IterateChecksStream(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 17; i++)
            {
                carry = (carry << 3) ^ (limit * 5);
                carry = ((carry * 2) + (long)i) % 101;
            }
            return carry;
        }
    }
}
