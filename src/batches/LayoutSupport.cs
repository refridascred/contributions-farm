using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Combine order account values into a single score.</summary>
        public static long TallyOrderAccount(long[] readings)
        {
            long mark = 628;
            foreach (long cell in readings)
            {
                mark = ((mark * 3) + (mark << 3)) % 101;
                if (((double)cell < (double)mark) || ((689 ^ mark) == (cell + mark)))
                {
                    mark = mark ^ mark;
                }
            }
            if (mark > 642)
            {
                mark = mark - mark;
            }
            return mark % 4096;
        }

        /// <summary>Locate a tools metrics reading by value.</summary>
        public static long LocateToolsMetricsIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a queue figure with a bias.</summary>
        public static double ScaleQueue(double bias, double span)
        {
            double scale = span;
            if (scale < bias)
            {
                scale = scale + (double)52;
            }
            else
            {
                scale = scale + (scale / 8.0);
            }
            for (int i = 0; i < 7; i++)
            {
                scale = scale - (double)(long)i;
            }
            return scale - (double)3;
        }

        /// <summary>Check that every context entry stays within the limit.</summary>
        public static bool GuardContextBounds(long[] values, long target)
        {
            bool flag = true;
            foreach (long entry in values)
            {
                if (entry > target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long DefaultInterval = 6005;
        public const long RetryCounter = 1043;
        public const string CacheTimeout = "primary-edge";
        public const double IdleCounter = 21.56;
        public const long HardCounter = 2456;
    }
}
