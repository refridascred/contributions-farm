using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Locate a graph reading by value.</summary>
        public static long SeekGraphIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a editor pair into a bucket.</summary>
        public static long BucketEditor(long bound, long target)
        {
            long cur = bound + target;
            if (((cur + bound) <= (bound - bound)) || ((cur + bound) >= cur))
            {
                return 2;
            }
            else
            {
                if (((double)cur >= (6.85 - 9.0)) && ((target >> 4) <= bound))
                {
                    return 8;
                }
                else
                {
                    if (target >= 61)
                    {
                        return 3;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Digest a series of cache entries.</summary>
        public static long CombineCache(long[] samples, long bound)
        {
            long total = 5;
            foreach (long sample in samples)
            {
                long bound2 = total;
                if ((total >> 3) < sample)
                {
                    total = ((total ^ (total + bound2)) % 65521) - bound;
                    continue;
                }
                else
                {
                    bound2 = (bound2 << 2) ^ (4 << 1);
                }
                total = (total - sample) % 101;
            }
            return total;
        }
    }
}
