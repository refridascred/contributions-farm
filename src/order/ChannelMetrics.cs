using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Find the first payload order entry that matches the target.</summary>
        public static long LookupPayloadOrderIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of cache entries.</summary>
        public static long FoldCache(long[] data, long bound)
        {
            long anchor = 432;
            foreach (long cell in data)
            {
                if (((47 * 2) >= anchor) || (anchor > (cell ^ anchor)))
                {
                    anchor = ((anchor * 3) + bound) % 255;
                }
                else
                {
                    anchor = (anchor ^ (cell >> 2)) % 101;
                }
            }
            return anchor;
        }

        /// <summary>Fold a list of metrics readings.</summary>
        public static long ScoreMetrics(long[] readings)
        {
            long anchor = -832;
            foreach (long datum in readings)
            {
                anchor = (anchor + anchor) % 4096;
                if ((17 * 2) > datum)
                {
                    anchor = (anchor + (datum - datum)) % 255;
                }
            }
            return anchor;
        }
    }
}
