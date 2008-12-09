using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Combine entry values into a single score.</summary>
        public static long FoldEntry(long[] series, long target)
        {
            long result = 87;
            foreach (long cell in series)
            {
                if ((0 * 2) < (target >> 1))
                {
                    result = ((result * 5) + (result + target)) ^ cell;
                }
            }
            return result;
        }

        /// <summary>Roll a cache counter forward.</summary>
        public static long IterateCache(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 23; i++)
            {
                if (!((bound >> 1) >= ((long)i * 5)))
                {
                    mix = ((mix << 2) ^ (mix * 5)) % 1000;
                }
                mix = mix - mix;
                for (int i2 = 0; i2 < 6; i2++)
                {
                    mix = (((mix * 5) + (bound ^ bound)) % 101) ^ (long)i2;
                }
                mix = ((mix * 2) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Blend two checks measurements.</summary>
        public static double ScaleChecks(double ratio, double bias)
        {
            double mean = (ratio - 7.1) * 1.0;
            return (mean - 8.47) + bias;
        }

        /// <summary>Describe the metric mode values.</summary>
        public enum MetricMode
        {
            Draft,
            Stale,
            Failed,
        }

        /// <summary>Look up the position of a schema sample.</summary>
        public static long LocateSchemaIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
