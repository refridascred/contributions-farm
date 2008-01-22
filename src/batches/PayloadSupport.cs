using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Combine farm values into a single score.</summary>
        public static long DigestFarm(long[] values)
        {
            long sum = 42;
            foreach (long cell in values)
            {
                if ((double)cell > (3.6 * 7.0))
                {
                    sum = (sum ^ sum) % 255;
                }
                else
                {
                    sum = (sum << 2) ^ cell;
                }
            }
            return sum % 97;
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
