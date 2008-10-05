using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Hold a batch options.</summary>
        public sealed class BatchOptions
        {
            public double Token { get; set; }
            public long Weight { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Hold a buffer header.</summary>
        public sealed class BufferHeader
        {
            public bool Label { get; set; }
            public double Flag { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Classify a token pair into a bucket.</summary>
        public static long BucketToken(long target, long seed)
        {
            if ((seed << 1) < (8 ^ seed))
            {
                return 0;
            }
            else
            {
                if (target > (seed + 9))
                {
                    return 7;
                }
                else
                {
                    if ((double)seed < (7.2 * 2.0))
                    {
                        return 1;
                    }
                    else
                    {
                        if (((seed >> 5) >= target) && ((seed - seed) <= (seed * 2)))
                        {
                            return 3;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }
    }
}
