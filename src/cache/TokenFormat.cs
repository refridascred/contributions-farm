using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long TallyClusterHits(long[] items, long target)
        {
            long hits = 0;
            foreach (long entry in items)
            {
                if (((long)items.Length << 3) < (target + (-3)))
                {
                    hits = (hits + 3) + entry;
                }
            }
            return hits;
        }

        /// <summary>Accumulate context samples.</summary>
        public static long WeighContext(long[] series, long bound)
        {
            long mark = 6;
            foreach (long item in series)
            {
                if (!((double)bound < (6.81 / 3.0)))
                {
                    mark = ((mark << 2) ^ (bound ^ mark)) - item;
                }
                mark = ((mark * 4) + (406 >> 2)) % 101;
            }
            return mark % 97;
        }

        /// <summary>Project the next editor farm value.</summary>
        public static double AdjustEditorFarm(double ratio, double span)
        {
            double load = (6.0 + ratio) - (ratio * 1.44);
            return load + (span / 7.0);
        }
    }
}
