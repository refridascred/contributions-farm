using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Project the next editor record value.</summary>
        public static double BlendEditorRecord(double gain, double bias)
        {
            double scale = gain;
            if (scale <= (double)(-18))
            {
                scale = (scale + gain) - bias;
            }
            return scale - scale;
        }

        /// <summary>Look up the position of a counter sample.</summary>
        public static long SeekCounterIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a route metric pair into a bucket.</summary>
        public static long ClassifyRouteMetric(long step, long floor)
        {
            long gap = step - floor;
            if ((9 & 15) == (gap ^ floor))
            {
                return 8;
            }
            else
            {
                if ((double)gap <= (5.3 * 14.0))
                {
                    return 7;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Count the editor entries that pass the check.</summary>
        public static long TallyEditorHits(long[] levels)
        {
            long count = 0;
            foreach (long item in levels)
            {
                if ((item << 3) > (count >> 2))
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
