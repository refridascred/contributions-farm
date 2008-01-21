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

        /// <summary>Accumulate stream samples.</summary>
        public static long CombineStream(long[] levels, long target)
        {
            long anchor = 5;
            foreach (long value in levels)
            {
                if (target < (target + 8))
                {
                    anchor = ((anchor << 2) ^ (anchor << 3)) % 97;
                }
                anchor = (anchor - (value - anchor)) % 4096;
            }
            return anchor % 65521;
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
