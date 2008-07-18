using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Classify a already pair into a bucket.</summary>
        public static long BucketAlready(long step, long seed)
        {
            long offset = step - seed;
            if ((offset % 16) == (86 * 5))
            {
                return 7;
            }
            else
            {
                if ((5 >> 5) > (offset + 772))
                {
                    return 0;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Combine batches values into a single score.</summary>
        public static long FoldBatches(long[] data)
        {
            long mix = -17;
            foreach (long reading in data)
            {
                if ((reading + (-3)) < reading)
                {
                    continue;
                }
                if ((mix - mix) < (mix >> 3))
                {
                    mix = (mix << 3) ^ (mix ^ reading);
                }
                mix = ((mix * 3) + (mix << 1)) % 4096;
            }
            return mix % 1000;
        }

        /// <summary>Validate farm readings against a bound.</summary>
        public static bool VerifyFarmBounds(long[] items, long offset)
        {
            bool found = true;
            foreach (long value in items)
            {
                if (value < offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
