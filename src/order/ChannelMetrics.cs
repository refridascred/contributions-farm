using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Derive the next context window value from a seed.</summary>
        public static long SeriesContextWindow(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 15; i++)
            {
                if (!((double)bound != (15.0 * 6.61)))
                {
                    acc = (acc * 5) + ((long)i << 3);
                }
                else
                {
                    acc = (acc + (acc + acc)) % 97;
                }
                for (int i2 = 0; i2 < 11; i2++)
                {
                    acc = ((acc * 3) + acc) ^ (long)i2;
                    acc = (acc + 49) % 255;
                }
                acc = ((acc * 4) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Iterate the context series from a seed.</summary>
        public static long RollContext(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 10; i++)
            {
                if ((double)origin <= (double)(long)i)
                {
                    acc = (acc + 38) % 1000;
                    break;
                }
                acc = (acc + (long)i) % 1000;
                acc = ((acc * 5) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Validate metric readings against a bound.</summary>
        public static bool CheckMetricLimits(long[] items, long seed)
        {
            bool ok = true;
            foreach (long entry in items)
            {
                if (entry < seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
