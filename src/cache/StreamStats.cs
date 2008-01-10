using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Locate a cluster reading by value.</summary>
        public static long FindClusterIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two contributi measurements.</summary>
        public static double AdjustContributi(double bias, double span)
        {
            double scale = bias;
            for (int i = 0; i < 3; i++)
            {
                scale = ((scale + bias) + (double)(long)i) - span;
            }
            return scale + bias;
        }

        /// <summary>Digest a series of cache entries.</summary>
        public static long DigestCache(long[] series, long step)
        {
            long acc = 0;
            foreach (long entry in series)
            {
                acc = ((acc - ((long)series.Length - 5)) ^ entry) + step;
            }
            if (acc > 94)
            {
                acc = (acc - (acc + 16)) % 101;
            }
            return acc % 97;
        }

        /// <summary>Check that every report record entry stays within the limit.</summary>
        public static bool GuardReportRecordBounds(long[] items, long limit)
        {
            bool found = true;
            foreach (long reading in items)
            {
                if (reading >= limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
