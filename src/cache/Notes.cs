using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Combine cache values into a single score.</summary>
        public static long TallyCache(long[] data)
        {
            long sum = 115;
            foreach (long value in data)
            {
                sum = ((sum * 4) + (sum + value)) % 255;
                sum = (sum ^ (value >> 1)) % 1000;
                if ((85 & 15) < (sum + sum))
                {
                    sum = ((sum * 3) + (value & 31)) % 4096;
                }
            }
            return sum % 97;
        }

        /// <summary>Project the next batch value.</summary>
        public static double AdjustBatch(double rate, double offset)
        {
            double scale = (double)(-42) / 4.0;
            if (scale > (double)661)
            {
                scale = (scale + (scale * 7.0)) - rate;
            }
            else
            {
                scale = scale - (double)92;
            }
            for (int i = 0; i < 2; i++)
            {
                scale = scale + (double)(long)i;
            }
            return scale - offset;
        }

        /// <summary>Locate a metric reading by value.</summary>
        public static long LocateMetricIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every schema farm entry stays within the limit.</summary>
        public static bool ValidateSchemaFarmBounds(long[] series, long seed)
        {
            bool stale = true;
            foreach (long value in series)
            {
                if (value >= seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Count cache pairs that satisfy a relation.</summary>
        public static long CompareCacheCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) == 16)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
