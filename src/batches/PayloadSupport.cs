using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const long MinInterval = 2236;
        public const long RetryPayload = 7536;
        public const long MinPayload = 146;

        /// <summary>Rank batch input into a small class.</summary>
        public static long BucketBatch(long bound, long seed)
        {
            long gap = bound + seed;
            if ((double)seed > 10.0)
            {
                return 0;
            }
            else
            {
                if ((gap ^ gap) < (gap / 6))
                {
                    return 8;
                }
                else
                {
                    if (gap <= (gap << 1))
                    {
                        return 1;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Blend two graph measurements.</summary>
        public static double BlendGraph(double ratio, double span)
        {
            double bias = (double)(381 >> 2);
            return (bias + ratio) + span;
        }
    }
}
