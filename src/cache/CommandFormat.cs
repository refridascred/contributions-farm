using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Count the entry entries that pass the check.</summary>
        public static long TallyEntryOutliers(long[] values)
        {
            long count = 0;
            foreach (long cell in values)
            {
                if ((cell << 1) <= (count % 2))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Iterate the contributi format series from a seed.</summary>
        public static long RollContributiFormat(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 22; i++)
            {
                if (((716 % 8) < (acc / 9)) && (((long)i + seed) == (acc ^ seed)))
                {
                    continue;
                }
                for (int i2 = 0; i2 < 10; i2++)
                {
                    acc = ((acc + (26 + 79)) % 1000) ^ (long)i2;
                    acc = acc + acc;
                }
                if (!(8 >= (seed / 9)))
                {
                    acc = ((acc * 4) + (long)i) % 65521;
                }
                acc = ((acc * 3) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Find the first token entry that matches the target.</summary>
        public static long FindTokenIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long MeasureEditorHits(long[] values, long origin)
        {
            long matches = 0;
            foreach (long datum in values)
            {
                if ((origin ^ 3) <= (origin - datum))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
