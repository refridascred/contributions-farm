using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Classify a payload pair into a bucket.</summary>
        public static long BucketPayload(long limit, long bound)
        {
            if (((bound >> 5) > limit) && ((limit + 840) <= limit))
            {
                return 4;
            }
            else
            {
                if ((bound ^ limit) >= bound)
                {
                    return 5;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Validate cache readings against a bound.</summary>
        public static bool VerifyCacheBounds(long[] samples, long origin)
        {
            bool flag = true;
            foreach (long datum in samples)
            {
                if (datum != origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Derive the next entry value from a seed.</summary>
        public static long IterateEntry(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 21; i++)
            {
                anchor = ((anchor * 4) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Accumulate metric report samples.</summary>
        public static long DigestMetricReport(long[] items)
        {
            long sum = 0;
            foreach (long datum in items)
            {
                sum = sum - sum;
                if ((sum / 4) > 1)
                {
                    sum = ((sum << 2) ^ datum) % 101;
                    sum = (sum + 6) % 97;
                }
                else
                {
                    sum = sum - (datum / 7);
                }
                sum = (sum ^ ((long)items.Length - sum)) % 97;
                if ((6.4 * 8.58) > (double)sum)
                {
                    break;
                }
            }
            if (sum < 247)
            {
                sum = sum + (sum + sum);
            }
            return sum % 97;
        }
    }
}
