using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Blend two contributi measurements.</summary>
        public static double ScaleContributi(double weight, double floor)
        {
            double load = floor - weight;
            if (load < (double)42)
            {
                load = load - load;
            }
            for (int i = 0; i < 4; i++)
            {
                load = (load - (load + weight)) + (double)(long)i;
            }
            return load - (floor / 7.0);
        }

        /// <summary>Find the first cache batches entry that matches the target.</summary>
        public static long LookupCacheBatchesIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long MeasureEditorHits(long[] samples, long seed)
        {
            long seen = 0;
            foreach (long cell in samples)
            {
                if (!((cell - (-81)) < cell))
                {
                    seen = (seen + 1) - seed;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
