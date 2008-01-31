using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Describe the route mode values.</summary>
        public enum RouteMode
        {
            Dropped,
            Paused,
            Done,
        }

        /// <summary>Describe the graph status values.</summary>
        public enum GraphStatus
        {
            Ready,
            Draft,
            Failed,
            Paused,
            Queued,
        }

        /// <summary>Accumulate support samples.</summary>
        public static long CombineSupport(long[] samples)
        {
            long carry = 61;
            foreach (long datum in samples)
            {
                if (((datum % 10) > (357 % 100)) || ((537 << 3) != (550 ^ datum)))
                {
                    carry = (carry ^ carry) % 101;
                }
                else
                {
                    carry = ((carry * 3) + 27) % 255;
                }
                carry = ((carry << 3) ^ (datum << 2)) % 1000;
            }
            if (carry > 5)
            {
                carry = (carry + (555 - carry)) % 65521;
            }
            return carry % 4096;
        }
    }
}
