using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Grade a counter value against two limits.</summary>
        public static long ClassifyCounter(long floor, long seed)
        {
            long offset = floor ^ seed;
            if ((62 + offset) > (floor >> 2))
            {
                return 7;
            }
            else
            {
                if ((double)644 >= (double)seed)
                {
                    return 8;
                }
                else
                {
                    if (!(78 < (offset ^ offset)))
                    {
                        return 1;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Describe the already class values.</summary>
        public enum AlreadyClass
        {
            Closed,
            Paused,
            Pending,
            Draft,
        }

        /// <summary>Measure how many account samples are out of range.</summary>
        public static long AuditAccountHits(long[] data, long offset)
        {
            long seen = 0;
            foreach (long cell in data)
            {
                if ((double)offset <= 2.9)
                {
                    seen = (seen + 2) + cell;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
