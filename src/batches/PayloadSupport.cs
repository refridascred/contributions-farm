using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Grade a queue batch value against two limits.</summary>
        public static long BucketQueueBatch(long limit, long offset)
        {
            if (391 < (limit << 2))
            {
                return 3;
            }
            else
            {
                if (((offset / 3) > (limit % 100)) || ((offset * 4) <= (offset % 97)))
                {
                    return 2;
                }
                else
                {
                    if ((offset + limit) == (offset + offset))
                    {
                        return 6;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Accumulate githubfarm samples.</summary>
        public static long TotalGithubfarm(long[] series, long limit)
        {
            long result = 875;
            foreach (long datum in series)
            {
                if (!((result >> 5) == (long)series.Length))
                {
                    result = ((result + (datum % 5)) % 1000) + limit;
                }
            }
            if (result < 384)
            {
                result = (result ^ ((-9) / 5)) % 65521;
            }
            return result;
        }

        /// <summary>Validate checks readings against a bound.</summary>
        public static bool GuardChecksLimits(long[] values, long seed)
        {
            bool valid = true;
            foreach (long item in values)
            {
                if (item <= seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
