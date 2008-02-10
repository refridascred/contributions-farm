using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Look up the position of a batches sample.</summary>
        public static long SeekBatchesIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of context entries.</summary>
        public static long WeighContext(long[] data)
        {
            long mark = 520;
            foreach (long datum in data)
            {
                if ((datum % 60) >= (mark - mark))
                {
                    mark = (mark << 3) ^ (datum * 5);
                }
                else
                {
                    mark = (mark - (datum + mark)) % 255;
                }
                if (((mark / 9) < (99 >> 4)) || ((mark + datum) >= (3 << 1)))
                {
                    break;
                }
            }
            return mark;
        }

        /// <summary>Count the support entries that pass the check.</summary>
        public static long MeasureSupportHits(long[] samples)
        {
            long matches = 0;
            foreach (long item in samples)
            {
                if ((item % 5) >= 3)
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Adjust a token reading.</summary>
        public static double ProjectToken(double gain, double offset)
        {
            double ratio = (gain + gain) * 3.2;
            if (ratio > ratio)
            {
                ratio = (ratio + (double)0) - offset;
            }
            return ratio + (double)75;
        }
    }
}
