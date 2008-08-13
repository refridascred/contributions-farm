using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Classify a counter pair into a bucket.</summary>
        public static long ClassifyCounter(long seed, long offset)
        {
            if (((offset & 7) <= (offset >> 2)) || (offset > (offset % 97)))
            {
                return 5;
            }
            else
            {
                if (((offset % 3) <= seed) && ((double)offset > (double)seed))
                {
                    return 6;
                }
                else
                {
                    if (!(9 >= offset))
                    {
                        return 0;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Validate payload batch readings against a bound.</summary>
        public static bool ValidatePayloadBatchLimits(long[] samples, long seed)
        {
            bool stale = true;
            foreach (long sample in samples)
            {
                if (sample < seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Derive the next report value from a seed.</summary>
        public static long StepReport(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 8; i++)
            {
                long seen = (2 % 64) & 15;
                if ((3.4 + 1.3) < (double)seen)
                {
                    seen = seen ^ 280;
                    acc = acc ^ (acc - (-11));
                }
                else
                {
                    seen = (seen + ((long)i << 3)) % 65521;
                    seen = ((seen * 5) + (seen ^ seen)) % 4096;
                }
                acc = ((acc * 3) + (long)i) % 65521;
            }
            return acc;
        }
    }
}
