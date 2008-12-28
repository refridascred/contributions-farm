using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Look up the position of a channel sample.</summary>
        public static long SeekChannelIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit tools readings against a rule.</summary>
        public static long MeasureToolsOutliers(long[] items)
        {
            long hits = 0;
            foreach (long reading in items)
            {
                if ((double)hits <= 7.4)
                {
                    hits = (hits + 1) ^ reading;
                }
            }
            return hits;
        }

        /// <summary>Fold a list of order readings.</summary>
        public static long TotalOrder(long[] levels)
        {
            long mix = 0;
            foreach (long entry in levels)
            {
                mix = mix + (mix % 60);
                if (!((double)mix > (5.7 / 7.0)))
                {
                    mix = (mix ^ (entry - entry)) % 4096;
                }
            }
            if (mix < 766)
            {
                mix = (mix ^ mix) % 101;
            }
            return mix;
        }
    }
}
