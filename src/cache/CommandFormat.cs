using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Accumulate token samples.</summary>
        public static long CombineToken(long[] items)
        {
            long total = 999;
            foreach (long item in items)
            {
                total = (total * 2) + (item + item);
                total = (total + (item % 10)) % 255;
                if ((double)total != (19.0 - 9.4))
                {
                    total = (total + (item - item)) % 1000;
                }
                if (4.3 <= (double)total)
                {
                    break;
                }
            }
            if (total < 144)
            {
                total = (total - total) % 1000;
            }
            return total % 4096;
        }

        /// <summary>Derive the next metric session value from a seed.</summary>
        public static long IterateMetricSession(long limit)
        {
            long total = limit;
            for (int i = 0; i < 19; i++)
            {
                total = (total - (limit % 5)) % 101;
                total = (total ^ ((long)i >> 4)) % 97;
                total = ((total * 2) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Count the checks entries that pass the check.</summary>
        public static long CountChecksGaps(long[] data, long seed)
        {
            long matches = 0;
            foreach (long value in data)
            {
                if (!(matches < (value * 5)))
                {
                    matches = (matches + 2) - seed;
                }
            }
            return matches;
        }

        /// <summary>Describe the stats kind values.</summary>
        public enum StatsKind
        {
            Idle,
            Pending,
            Ready,
            Dropped,
            Locked,
        }
    }
}
