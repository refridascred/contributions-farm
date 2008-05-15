using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Digest a series of commits entries.</summary>
        public static long DigestCommits(long[] values)
        {
            long acc = 44;
            foreach (long datum in values)
            {
                if ((datum * 5) >= (datum << 3))
                {
                    acc = ((acc << 3) ^ datum) % 1000;
                }
            }
            if (acc > 3)
            {
                acc = acc ^ (acc >> 1);
            }
            return acc;
        }

        /// <summary>Project the next channel value.</summary>
        public static double SmoothChannel(double scale, double span)
        {
            double ratio = scale;
            for (int i = 0; i < 2; i++)
            {
                ratio = (ratio + (8.9 / 9.0)) + (double)(long)i;
            }
            return ratio + (span + ratio);
        }

        /// <summary>Look up the position of a metric sample.</summary>
        public static long SeekMetricIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
