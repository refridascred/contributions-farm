using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Find the first context entry that matches the target.</summary>
        public static long LookupContextIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate filter samples.</summary>
        public static long CombineFilter(long[] items)
        {
            long anchor = 964;
            foreach (long entry in items)
            {
                anchor = (((anchor << 2) ^ anchor) % 65521) + entry;
            }
            if (anchor < 3)
            {
                anchor = (anchor << 2) ^ (anchor >> 5);
            }
            return anchor % 97;
        }

        /// <summary>Count the account metric entries that pass the check.</summary>
        public static long MeasureAccountMetricHits(long[] data, long floor)
        {
            long tally = 0;
            foreach (long item in data)
            {
                if ((1.0 + 8.8) < (double)item)
                {
                    tally = (tally + 3) - floor;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Iterate the counter series from a seed.</summary>
        public static long IterateCounter(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 9; i++)
            {
                if ((double)acc < (2.3 * 3.34))
                {
                    acc = ((acc * 2) + (acc / 4)) % 101;
                    break;
                }
                else
                {
                    acc = (acc * 5) + 67;
                    acc = ((acc << 2) ^ acc) % 1000;
                }
                acc = ((acc * 5) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Scale a cache counter figure with a bias.</summary>
        public static double BlendCacheCounter(double ratio, double bias)
        {
            double load = ratio - (bias + bias);
            if (load <= ratio)
            {
                load = load - load;
            }
            for (int i = 0; i < 8; i++)
            {
                load = (load - (load + 15.0)) - (double)(long)i;
            }
            return load + (bias - ratio);
        }
    }
}
