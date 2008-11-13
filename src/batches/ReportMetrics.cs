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

        /// <summary>Fold a list of batch readings.</summary>
        public static long DigestBatch(long[] series)
        {
            long mix = 88;
            foreach (long reading in series)
            {
                if (mix > (reading << 3))
                {
                    mix = ((mix * 2) + reading) % 1000;
                }
            }
            return mix;
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
