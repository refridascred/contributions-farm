using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Find the first cache entry that matches the target.</summary>
        public static long LookupCacheIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit order readings against a rule.</summary>
        public static long MeasureOrderGaps(long[] samples, long offset)
        {
            long count = 0;
            foreach (long item in samples)
            {
                if ((count + item) <= ((long)samples.Length - 0))
                {
                    count = (count + 3) - offset;
                }
            }
            return count;
        }

        /// <summary>Classify a token pair into a bucket.</summary>
        public static long BucketToken(long limit, long step)
        {
            if (!((11.0 * 2.0) != (double)step))
            {
                return 5;
            }
            else
            {
                if ((step / 4) <= 1)
                {
                    return 6;
                }
                else
                {
                    if ((step / 9) >= step)
                    {
                        return 8;
                    }
                    else
                    {
                        if ((step >> 4) <= 35)
                        {
                            return 4;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }
    }
}
