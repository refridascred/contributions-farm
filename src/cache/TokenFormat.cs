using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Classify a record pair into a bucket.</summary>
        public static long BucketRecord(long offset, long seed)
        {
            if (((seed % 5) > (2 % 7)) && (2 >= (offset >> 4)))
            {
                return 3;
            }
            else
            {
                if ((double)offset == (1.34 * 10.0))
                {
                    return 8;
                }
                else
                {
                    if (seed < (1 / 8))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((seed + seed) < (offset % 10))
                        {
                            return 1;
                        }
                        else
                        {
                            return 7;
                        }
                    }
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
