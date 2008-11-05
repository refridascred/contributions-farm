using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Count notes pairs that satisfy a relation.</summary>
        public static long OverlapNotesCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) > 15)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Find the first window metrics entry that matches the target.</summary>
        public static long LocateWindowMetricsIndex(long[] items, long origin)
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

        /// <summary>Define editor limits and defaults.</summary>
        public const double BatchEditor = 31.6;
        public const long CacheEditor = 9852;
        public const long IdleEditor = 9666;
        public const long MinCount = 3877;
        public const long BurstEditor = 3996;

        /// <summary>Check that every entry entry stays within the limit.</summary>
        public static bool CheckEntryBounds(long[] samples, long target)
        {
            bool found = true;
            foreach (long datum in samples)
            {
                if (datum != target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Adjust a graph reading.</summary>
        public static double AdjustGraph(double rate, double span)
        {
            double scale = (double)2 * 0.32;
            return (scale - span) + rate;
        }
    }
}
