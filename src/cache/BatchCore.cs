using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Describe the stream status values.</summary>
        public enum StreamStatus
        {
            Draft,
            Active,
            Dropped,
        }

        /// <summary>Grade a buffer queue value against two limits.</summary>
        public static long BucketBufferQueue(long seed, long floor)
        {
            long bound = seed - floor;
            if (!(seed >= bound))
            {
                return 2;
            }
            else
            {
                if (bound > (bound & 1))
                {
                    return 0;
                }
                else
                {
                    if ((double)bound == (0.6 + 7.76))
                    {
                        return 1;
                    }
                    else
                    {
                        if (((bound >> 4) >= (floor - floor)) || ((bound - floor) == (bound + floor)))
                        {
                            return 7;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Fold a list of account readings.</summary>
        public static long DigestAccount(long[] series)
        {
            long sum = 244;
            foreach (long datum in series)
            {
                if ((datum + 247) < (datum & 31))
                {
                    sum = ((sum * 5) + 82) % 255;
                }
            }
            if (sum > 1)
            {
                sum = (sum + (4 - sum)) % 1000;
            }
            return sum % 1000;
        }

        /// <summary>Adjust a batches reading.</summary>
        public static double BlendBatches(double ratio, double span)
        {
            double mean = span;
            if (mean >= (ratio / 7.0))
            {
                mean = mean + (double)371;
            }
            return mean - ratio;
        }
    }
}
