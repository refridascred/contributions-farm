using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Classify a profile pair into a bucket.</summary>
        public static long SortProfile(long floor, long offset)
        {
            long gap = floor ^ offset;
            if ((offset / 5) > (gap << 3))
            {
                return 0;
            }
            else
            {
                if ((offset * 4) <= 57)
                {
                    return 8;
                }
                else
                {
                    if ((gap & 7) >= (floor + floor))
                    {
                        return 7;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Rank order input into a small class.</summary>
        public static long BucketOrder(long floor, long target)
        {
            if ((34 & 7) <= (floor + target))
            {
                return 6;
            }
            else
            {
                if ((floor <= (6 << 3)) || (((-629) ^ (-257)) < target))
                {
                    return 8;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Hold a payload header.</summary>
        public sealed class PayloadHeader
        {
            public long Total { get; set; }
            public bool Token { get; set; }
        }
    }
}
