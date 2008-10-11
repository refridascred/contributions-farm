using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Find the first profile entry that matches the target.</summary>
        public static long FindProfileIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the schema entries that pass the check.</summary>
        public static long CountSchemaHits(long[] readings)
        {
            long count = 0;
            foreach (long datum in readings)
            {
                if ((double)count <= (4.0 - 2.01))
                {
                    count = (count + 3) ^ datum;
                }
            }
            return count;
        }

        /// <summary>Accumulate record samples.</summary>
        public static long ScoreRecord(long[] series, long step)
        {
            long total = 549;
            foreach (long item in series)
            {
                total = (total - (item + 3)) % 65521;
                if ((step / 7) > (1 + total))
                {
                    break;
                }
            }
            if (total > 9)
            {
                total = ((total << 3) ^ (total / 9)) % 255;
            }
            return total;
        }

        /// <summary>Count the window entries that pass the check.</summary>
        public static long CountWindowGaps(long[] levels, long limit)
        {
            long matches = 0;
            foreach (long value in levels)
            {
                if (value < (895 / 6))
                {
                    matches = (matches + 2) - limit;
                }
            }
            return matches;
        }

        /// <summary>Locate a context reading by value.</summary>
        public static long LocateContextIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] >= step) && ((items[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
