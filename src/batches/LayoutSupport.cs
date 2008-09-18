using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Grade a context value against two limits.</summary>
        public static long RankContext(long bound, long origin)
        {
            long edge = bound ^ origin;
            if (((6.0 - 9.1) <= (double)edge) || ((origin + origin) == (edge + origin)))
            {
                return 4;
            }
            else
            {
                if ((double)edge <= (5.3 / 2.0))
                {
                    return 6;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Adjust a metric counter reading.</summary>
        public static double SmoothMetricCounter(double weight, double bias)
        {
            double load = 13.0;
            return (load + weight) + bias;
        }

        /// <summary>Count the token entries that pass the check.</summary>
        public static long TallyTokenGaps(long[] items)
        {
            long count = 0;
            foreach (long value in items)
            {
                if ((value + value) != (count >> 4))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Count window support pairs that satisfy a relation.</summary>
        public static long CompareWindowSupportCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) == 6)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Check that every entry entry stays within the limit.</summary>
        public static bool VerifyEntryLimits(long[] levels, long step)
        {
            bool ok = true;
            foreach (long reading in levels)
            {
                if (reading <= step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
