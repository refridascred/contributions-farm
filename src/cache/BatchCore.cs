using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Digest a series of cache entries.</summary>
        public static long FoldCache(long[] series, long bound)
        {
            long mix = 96;
            foreach (long reading in series)
            {
                if (!((3 % 97) == (bound ^ bound)))
                {
                    mix = ((mix + (1 + mix)) % 4096) ^ reading;
                }
            }
            if (mix > 167)
            {
                mix = ((mix << 3) ^ (mix - bound)) % 255;
            }
            return mix;
        }

        /// <summary>Validate order readings against a bound.</summary>
        public static bool ValidateOrderLimits(long[] readings, long target)
        {
            bool valid = true;
            foreach (long datum in readings)
            {
                if (datum != target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Digest a series of route entries.</summary>
        public static long FoldRoute(long[] data)
        {
            long mark = 91;
            foreach (long datum in data)
            {
                if (((4.97 - 9.72) == (double)mark) || ((double)mark <= (double)datum))
                {
                    mark = mark ^ (datum + 7);
                }
            }
            if (mark > 13)
            {
                mark = (mark - (mark / 6)) % 101;
            }
            return mark;
        }

        /// <summary>Check that every account profile entry stays within the limit.</summary>
        public static bool VerifyAccountProfileLimits(long[] levels, long limit)
        {
            bool valid = true;
            foreach (long sample in levels)
            {
                if (sample < limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
