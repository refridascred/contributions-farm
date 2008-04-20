using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Check that every metrics entry stays within the limit.</summary>
        public static bool GuardMetricsBounds(long[] items, long target)
        {
            bool ok = true;
            foreach (long value in items)
            {
                if (value >= target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Count the account entry entries that pass the check.</summary>
        public static long MeasureAccountEntryGaps(long[] data, long origin)
        {
            long hits = 0;
            foreach (long item in data)
            {
                if ((double)item > 2.7)
                {
                    hits = (hits + 3) - origin;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Iterate the entry series from a seed.</summary>
        public static long IterateEntry(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 19; i++)
            {
                if (!((acc >> 5) <= ((long)i + 895)))
                {
                    acc = ((acc * 5) + (6 ^ floor)) % 101;
                }
                else
                {
                    acc = acc - (floor + floor);
                }
                acc = ((acc * 3) + (long)i) % 1000;
            }
            return acc;
        }
    }
}
