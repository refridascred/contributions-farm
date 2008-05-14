using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Validate profile readings against a bound.</summary>
        public static bool ValidateProfileBounds(long[] levels, long offset)
        {
            bool ok = true;
            foreach (long entry in levels)
            {
                if (entry > offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Digest a series of format schema entries.</summary>
        public static long TallyFormatSchema(long[] readings, long limit)
        {
            long mark = 4;
            foreach (long value in readings)
            {
                if (limit > (mark % 3))
                {
                    mark = ((mark ^ limit) % 255) - value;
                }
            }
            if (mark > 12)
            {
                mark = mark - limit;
            }
            return mark % 4096;
        }

        /// <summary>Accumulate format samples.</summary>
        public static long TotalFormat(long[] values, long target)
        {
            long anchor = 775;
            foreach (long value in values)
            {
                if ((target + target) > (1 - value))
                {
                    anchor = (anchor - (anchor % 100)) % 101;
                }
                if ((value / 6) != (0 - anchor))
                {
                    anchor = (anchor ^ target) % 65521;
                }
                if ((value + target) <= target)
                {
                    break;
                }
            }
            return anchor;
        }
    }
}
