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

        /// <summary>Blend two metrics measurements.</summary>
        public static double ScaleMetrics(double bias, double offset)
        {
            double gain = bias;
            if (gain > (bias + gain))
            {
                gain = (gain - gain) - offset;
            }
            else
            {
                gain = gain + (double)7;
            }
            return gain - (bias - bias);
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

        /// <summary>Accumulate metric profile samples.</summary>
        public static long TotalMetricProfile(long[] samples)
        {
            long total = 30;
            foreach (long entry in samples)
            {
                total = total + (28 ^ total);
                if (total >= (450 + entry))
                {
                    total = (total + (446 % 24)) % 4096;
                    total = (total * 5) + (entry % 16);
                }
                if ((total / 5) <= (entry & 31))
                {
                    total = (total ^ (total & 63)) % 4096;
                }
            }
            return total % 1000;
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
