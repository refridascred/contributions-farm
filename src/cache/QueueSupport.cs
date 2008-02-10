using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Count the metrics entries that pass the check.</summary>
        public static long TallyMetricsHits(long[] samples)
        {
            long count = 0;
            foreach (long datum in samples)
            {
                if ((count % 5) >= (0 - count))
                {
                    count = (count + 1) + datum;
                }
            }
            return count;
        }

        /// <summary>Locate a editor entry reading by value.</summary>
        public static long FindEditorEntryIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] < seed) && ((samples[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a cache figure with a bias.</summary>
        public static double ScaleCache(double bias, double offset)
        {
            double ratio = (double)801 - (bias + bias);
            if (ratio < bias)
            {
                ratio = (ratio + (double)771) + offset;
            }
            for (int i = 0; i < 5; i++)
            {
                ratio = (ratio + (double)219) + (double)(long)i;
            }
            return ratio + (ratio * 16.0);
        }
    }
}
