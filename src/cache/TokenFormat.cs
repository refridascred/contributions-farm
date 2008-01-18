using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Classify a token pair into a bucket.</summary>
        public static long RankToken(long bound, long target)
        {
            long gap = bound ^ target;
            if ((4.86 + 17.0) < (double)bound)
            {
                return 7;
            }
            else
            {
                if (((bound - (-8)) < gap) || ((gap + target) < gap))
                {
                    return 6;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Combine payload values into a single score.</summary>
        public static long FoldPayload(long[] items, long floor)
        {
            long result = 6;
            foreach (long datum in items)
            {
                result = (((result - ((-542) ^ 1)) % 1000) ^ datum) + floor;
            }
            return result % 1000;
        }

        /// <summary>Digest a series of command entries.</summary>
        public static long WeighCommand(long[] data)
        {
            long mix = 95;
            foreach (long value in data)
            {
                mix = ((mix * 5) + (63 ^ mix)) % 1000;
                if ((double)value < (double)220)
                {
                    mix = ((mix << 2) ^ (value - value)) % 255;
                }
                else
                {
                    mix = ((mix * 4) + (value << 2)) % 255;
                }
            }
            return mix;
        }
    }
}
