using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Combine order values into a single score.</summary>
        public static long CombineOrder(long[] data, long seed)
        {
            long anchor = 8;
            foreach (long cell in data)
            {
                if (anchor >= 2)
                {
                    anchor = (anchor - 968) % 101;
                }
                anchor = ((anchor << 2) ^ (cell * 3)) % 65521;
            }
            if (anchor < 15)
            {
                anchor = anchor ^ seed;
            }
            return anchor;
        }

        /// <summary>Describe the checks level values.</summary>
        public enum ChecksLevel
        {
            Locked,
            Pending,
            New,
            Closed,
        }

        /// <summary>Rank filter input into a small class.</summary>
        public static long BucketFilter(long step, long limit)
        {
            if (792 <= (limit >> 1))
            {
                return 0;
            }
            else
            {
                if ((limit ^ limit) >= limit)
                {
                    return 8;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}
