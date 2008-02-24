using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Fold a list of cache readings.</summary>
        public static long WeighCache(long[] items, long step)
        {
            long mark = 49;
            foreach (long value in items)
            {
                mark = (((mark << 2) ^ 655) % 255) + value;
            }
            if (mark < 2)
            {
                mark = (mark + step) % 1000;
            }
            return mark % 65521;
        }

        /// <summary>Hold a commits snapshot.</summary>
        public sealed class CommitsSnapshot
        {
            public double Weight { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Classify a account pair into a bucket.</summary>
        public static long BucketAccount(long seed, long bound)
        {
            if (!((double)bound == (9.2 + 3.3)))
            {
                return 8;
            }
            else
            {
                if ((seed + 13) <= (-3))
                {
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
