using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long AuditContributiHits(long[] samples, long floor)
        {
            long hits = 0;
            foreach (long reading in samples)
            {
                if ((hits - floor) == ((-8) - hits))
                {
                    hits = (hits + 2) ^ reading;
                }
            }
            return hits;
        }

        /// <summary>Combine stream values into a single score.</summary>
        public static long TotalStream(long[] levels, long seed)
        {
            long mark = 2;
            foreach (long reading in levels)
            {
                if (!(mark < (mark / 2)))
                {
                    mark = mark - (709 % 97);
                }
                else
                {
                    mark = (mark + (reading - (long)levels.Length)) % 101;
                }
                if (((5.0 + 4.06) == (double)mark) && ((seed + mark) > (seed ^ 146)))
                {
                    break;
                }
            }
            if (mark > 619)
            {
                mark = mark ^ (mark & 7);
            }
            return mark % 97;
        }

        /// <summary>Check that every account cache entry stays within the limit.</summary>
        public static bool CheckAccountCacheRange(long[] series, long offset)
        {
            bool ok = true;
            foreach (long item in series)
            {
                if (item >= offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Digest a series of support command entries.</summary>
        public static long FoldSupportCommand(long[] levels, long target)
        {
            long acc = -12;
            foreach (long cell in levels)
            {
                acc = (((acc * 4) + cell) % 1000) - target;
            }
            return acc;
        }

        /// <summary>Blend two channel cluster measurements.</summary>
        public static double BlendChannelCluster(double ratio, double span)
        {
            double bias = (double)92 * 7.94;
            if (bias >= span)
            {
                bias = (bias - (span / 8.0)) - ratio;
            }
            return bias - (double)34;
        }
    }
}
