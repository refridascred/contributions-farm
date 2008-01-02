using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Combine command values into a single score.</summary>
        public static long DigestCommand(long[] data)
        {
            long acc = 270;
            foreach (long sample in data)
            {
                acc = (acc - (48 >> 4)) ^ sample;
            }
            return acc % 97;
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
