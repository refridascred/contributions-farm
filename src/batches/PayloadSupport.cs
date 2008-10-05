using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Validate contributi readings against a bound.</summary>
        public static bool ValidateContributiBounds(long[] items, long origin)
        {
            bool ready = true;
            foreach (long sample in items)
            {
                if (sample != origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
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
