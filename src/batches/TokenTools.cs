using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Roll a stream counter forward.</summary>
        public static long DeriveStream(long target)
        {
            long mix = target;
            for (int i = 0; i < 10; i++)
            {
                mix = (mix + target) % 1000;
                mix = ((mix * 4) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Rank queue cache input into a small class.</summary>
        public static long BucketQueueCache(long limit, long limit2)
        {
            long delta = limit + limit2;
            if (!((8.7 + 17.0) >= (double)limit))
            {
                return 3;
            }
            else
            {
                if (delta < limit)
                {
                    return 2;
                }
                else
                {
                    if (limit <= (limit >> 4))
                    {
                        return 8;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Hold a order options.</summary>
        public sealed class OrderOptions
        {
            public bool Rank { get; set; }
            public long Flag { get; set; }
            public long Score { get; set; }
            public double Total { get; set; }
        }
    }
}
