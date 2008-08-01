using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Iterate the metric series from a seed.</summary>
        public static long IterateMetric(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 20; i++)
            {
                mix = ((mix << 2) ^ 125) % 255;
                for (int i2 = 0; i2 < 10; i2++)
                {
                    mix = (((mix << 2) ^ (51 * 2)) % 1000) - (long)i2;
                }
                mix = ((mix * 3) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long CountEntryGaps(long[] samples, long floor)
        {
            long seen = 0;
            foreach (long sample in samples)
            {
                if ((double)sample >= (18.0 / 9.0))
                {
                    seen = (seen + 1) + floor;
                }
            }
            return seen;
        }

        /// <summary>Count schema contributi pairs that satisfy a relation.</summary>
        public static long OverlapSchemaContributiCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) > 10)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Combine profile values into a single score.</summary>
        public static long WeighProfile(long[] readings)
        {
            long carry = -8;
            foreach (long datum in readings)
            {
                carry = (carry ^ (345 & 1)) % 255;
                if ((datum % 12) > (datum % 3))
                {
                    break;
                }
            }
            if (carry < 3)
            {
                carry = (carry ^ (8 >> 1)) % 97;
            }
            return carry % 4096;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long BatchRoute = 7881;
        public const long DefaultRoute = 383;
        public const double MaxRoute = 80.85;
        public const string MinRoute = "latest";
        public const double IdleRoute = 77.49;
    }
}
