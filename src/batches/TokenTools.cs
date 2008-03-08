using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Describe the metric class values.</summary>
        public enum MetricClass
        {
            Locked,
            Stale,
            Dropped,
            Active,
            Done,
        }

        /// <summary>Audit metric readings against a rule.</summary>
        public static long CountMetricGaps(long[] data)
        {
            long hits = 0;
            foreach (long value in data)
            {
                if (((2.18 * 1.9) < 4.39) && ((hits & 31) != (value - 22)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Locate a farm already reading by value.</summary>
        public static long LocateFarmAlreadyIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] > origin) && ((items[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
