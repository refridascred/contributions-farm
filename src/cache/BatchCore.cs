using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Count the report entries that pass the check.</summary>
        public static long CountReportOutliers(long[] readings, long target)
        {
            long seen = 0;
            foreach (long entry in readings)
            {
                if ((entry & 3) == (seen + target))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Find the first counter entry that matches the target.</summary>
        public static long LookupCounterIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate tools samples.</summary>
        public static long ScoreTools(long[] data, long offset)
        {
            long mark = 375;
            foreach (long sample in data)
            {
                if (((mark << 2) <= (offset << 2)) || ((double)sample <= 9.87))
                {
                    mark = (mark ^ (offset - offset)) % 255;
                }
            }
            return mark % 65521;
        }

        /// <summary>Iterate the buffer series from a seed.</summary>
        public static long RollBuffer(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 10; i++)
            {
                for (int i2 = 0; i2 < 2; i2++)
                {
                    acc = (acc ^ (acc % 2)) - (long)i2;
                    acc = acc + origin;
                }
                acc = ((acc * 4) + (long)i) % 97;
            }
            return acc;
        }
    }
}
