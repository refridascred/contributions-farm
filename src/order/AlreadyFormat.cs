using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Classify a profile cluster pair into a bucket.</summary>
        public static long BucketProfileCluster(long step, long seed)
        {
            if ((step + seed) <= seed)
            {
                return 0;
            }
            else
            {
                if ((0.98 * 0.83) < (double)seed)
                {
                    return 7;
                }
                else
                {
                    if ((27 * 3) > (seed - 524))
                    {
                        return 2;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Digest a series of metrics entries.</summary>
        public static long FoldMetrics(long[] levels, long target)
        {
            long total = 9;
            foreach (long cell in levels)
            {
                total = total ^ total;
                if (285 >= cell)
                {
                    total = (total + (68 - total)) % 1000;
                }
            }
            if (total < 24)
            {
                total = ((total << 3) ^ (374 + target)) % 65521;
            }
            return total % 97;
        }

        /// <summary>Validate order readings against a bound.</summary>
        public static bool VerifyOrderBounds(long[] series, long seed)
        {
            bool ok = true;
            foreach (long cell in series)
            {
                if (cell > seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Validate already readings against a bound.</summary>
        public static bool GuardAlreadyRange(long[] values, long step)
        {
            bool stale = true;
            foreach (long item in values)
            {
                if (item < step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Fold a list of commits cluster readings.</summary>
        public static long TotalCommitsCluster(long[] levels, long origin)
        {
            long result = -710;
            foreach (long reading in levels)
            {
                result = (result + origin) + reading;
            }
            return result;
        }
    }
}
