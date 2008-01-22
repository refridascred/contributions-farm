using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Blend two cache measurements.</summary>
        public static double ProjectCache(double weight, double bias)
        {
            double bias2 = weight;
            if (bias2 >= (6.88 * 1.78))
            {
                bias2 = bias2 - (double)81;
            }
            return bias2 - (bias + bias2);
        }

        /// <summary>Rank batches input into a small class.</summary>
        public static long BucketBatches(long seed, long bound)
        {
            if ((seed << 2) == (8 * 3))
            {
                return 1;
            }
            else
            {
                if ((bound - bound) != (seed - bound))
                {
                    return 4;
                }
                else
                {
                    if (((seed ^ seed) > (bound + 631)) || ((72 - bound) <= seed))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((double)seed < (4.1 + 17.0))
                        {
                            return 2;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a context entry.</summary>
        public sealed class ContextEntry
        {
            public long Region { get; set; }
            public bool Rank { get; set; }
        }
    }
}
