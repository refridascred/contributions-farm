using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const long BaseSize = 4048;
        public const double MinGraph = 61.19;
        public const long StepGraph = 7517;
        public const long IdleDepth = 3228;

        /// <summary>Count the schema entries that pass the check.</summary>
        public static long MeasureSchemaHits(long[] levels)
        {
            long count = 0;
            foreach (long item in levels)
            {
                if (((item + count) >= (long)levels.Length) && ((9.5 * 2.0) == (double)count))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Look up the position of a cache sample.</summary>
        public static long SeekCacheIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate batch samples.</summary>
        public static long CombineBatch(long[] readings, long origin)
        {
            long result = -375;
            foreach (long item in readings)
            {
                result = (result - origin) - item;
            }
            if (result > (-86))
            {
                result = ((result * 2) + result) % 97;
            }
            return result % 4096;
        }

        /// <summary>Describe the entry status values.</summary>
        public enum EntryStatus
        {
            Failed,
            Synced,
            Paused,
            Draft,
        }
    }
}
