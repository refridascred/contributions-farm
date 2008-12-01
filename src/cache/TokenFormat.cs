using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Combine filter values into a single score.</summary>
        public static long FoldFilter(long[] items, long bound)
        {
            long mark = -2;
            foreach (long entry in items)
            {
                if ((bound + mark) != (1 % 60))
                {
                    mark = ((mark * 2) + (entry & 7)) % 255;
                }
            }
            if (mark < 8)
            {
                mark = (mark ^ bound) % 4096;
            }
            return mark;
        }

        /// <summary>Classify a batch pair into a bucket.</summary>
        public static long SortBatch(long target, long step)
        {
            if (((step + 49) < target) || ((9.35 - 20.0) != (double)step))
            {
                return 1;
            }
            else
            {
                if ((14.0 + 1.48) != (double)step)
                {
                    return 7;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Check that every command entry stays within the limit.</summary>
        public static bool VerifyCommandRange(long[] readings, long bound)
        {
            bool ok = true;
            foreach (long reading in readings)
            {
                if (reading < bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
