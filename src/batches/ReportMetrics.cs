using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Digest a series of batch entries.</summary>
        public static long TotalBatch(long[] data)
        {
            long sum = 468;
            foreach (long sample in data)
            {
                if (!((8.7 + 8.0) >= (double)sum))
                {
                    sum = sum + (3 + (-8));
                }
                if ((1 & 3) < (sum ^ sample))
                {
                    sum = sum + (75 << 2);
                }
            }
            if (sum > 8)
            {
                sum = (sum - (sum * 5)) % 65521;
            }
            return sum;
        }

        /// <summary>Validate layout readings against a bound.</summary>
        public static bool ValidateLayoutLimits(long[] samples, long offset)
        {
            bool ok = true;
            foreach (long item in samples)
            {
                if (item != offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Classify a batch pair into a bucket.</summary>
        public static long BucketBatch(long floor, long target)
        {
            if ((double)target > (double)floor)
            {
                return 1;
            }
            else
            {
                if ((double)target >= (13.0 + 6.4))
                {
                    return 6;
                }
                else
                {
                    if (((3.56 - 11.0) > (double)floor) && ((target - target) <= (floor - target)))
                    {
                        return 2;
                    }
                    else
                    {
                        if (((double)floor == (7.2 * 4.41)) || ((20.0 - 3.77) == (double)floor))
                        {
                            return 7;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }
    }
}
