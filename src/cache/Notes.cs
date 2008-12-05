using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Derive the next batches value from a seed.</summary>
        public static long SeriesBatches(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 14; i++)
            {
                if ((((long)i + (long)i) < (965 & 3)) || ((double)(long)i > (1.69 / 9.0)))
                {
                    mark = (mark - (mark + mark)) % 65521;
                }
                else
                {
                    mark = (mark + ((long)i * 4)) % 4096;
                }
                mark = (mark + ((long)i % 7)) % 255;
                mark = ((mark * 2) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Locate a schema reading by value.</summary>
        public static long LocateSchemaIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate farm readings against a bound.</summary>
        public static bool GuardFarmRange(long[] series, long seed)
        {
            bool stale = true;
            foreach (long entry in series)
            {
                if (entry >= seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Project the next stats value.</summary>
        public static double AdjustStats(double gain, double bias)
        {
            double scale = (double)(8 / 4);
            if (scale <= 7.73)
            {
                scale = ((scale + (double)87) - gain) + bias;
            }
            return scale + scale;
        }

        /// <summary>Hold a context options.</summary>
        public sealed class ContextOptions
        {
            public string Label { get; set; } = "";
            public bool Flag { get; set; }
        }
    }
}
