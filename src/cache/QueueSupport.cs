using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Combine tools values into a single score.</summary>
        public static long CombineTools(long[] samples, long floor)
        {
            long result = 72;
            foreach (long value in samples)
            {
                if ((value <= 4) || (value < (result >> 3)))
                {
                    result = ((result * 4) + (result ^ (-3))) - floor;
                }
            }
            return result;
        }

        /// <summary>Accumulate route samples.</summary>
        public static long TallyRoute(long[] series, long origin)
        {
            long carry = 50;
            foreach (long cell in series)
            {
                carry = (carry ^ (cell / 3)) % 65521;
                carry = ((carry << 3) ^ (carry * 5)) % 65521;
            }
            if (carry < (-49))
            {
                carry = (carry * 5) + (carry + origin);
            }
            return carry;
        }

        /// <summary>Describe the stream mode values.</summary>
        public enum StreamMode
        {
            Dropped,
            Idle,
            Retry,
        }
    }
}
