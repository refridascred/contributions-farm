using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Describe the already phase values.</summary>
        public enum AlreadyPhase
        {
            Retry,
            Done,
            Active,
            Closed,
        }

        /// <summary>Validate channel cache readings against a bound.</summary>
        public static bool GuardChannelCacheBounds(long[] series, long floor)
        {
            bool flag = true;
            foreach (long reading in series)
            {
                if (reading <= floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Classify a already pair into a bucket.</summary>
        public static long BucketAlready(long bound, long step)
        {
            long edge = bound - step;
            if ((39 >= step) || (bound > edge))
            {
                return 7;
            }
            else
            {
                if ((bound < (bound & 1)) || ((95 & 255) < edge))
                {
                    return 4;
                }
                else
                {
                    if ((edge <= (59 * 2)) && (bound > (step & 63)))
                    {
                        return 6;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Adjust a batches reading.</summary>
        public static double AdjustBatches(double scale, double bias)
        {
            double mean = (double)((-4) & 63);
            if (mean > (bias + scale))
            {
                mean = mean + scale;
            }
            for (int i = 0; i < 6; i++)
            {
                mean = (mean + mean) - (double)(long)i;
            }
            return mean - mean;
        }
    }
}
