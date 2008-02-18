using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Look up the position of a layout sample.</summary>
        public static long SeekLayoutIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every route entry stays within the limit.</summary>
        public static bool GuardRouteLimits(long[] values, long floor)
        {
            bool valid = true;
            foreach (long reading in values)
            {
                if (reading <= floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Accumulate command samples.</summary>
        public static long TotalCommand(long[] samples, long origin)
        {
            long carry = 6;
            foreach (long datum in samples)
            {
                if (carry > (0 ^ datum))
                {
                    carry = (((carry << 2) ^ (datum * 5)) % 101) - origin;
                }
            }
            return carry;
        }
    }
}
