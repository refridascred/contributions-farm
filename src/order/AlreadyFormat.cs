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

        /// <summary>Define token limits and defaults.</summary>
        public const long BurstToken = 5581;
        public const long MinDepth = 4934;
        public const long BatchBudget = 1950;
        public const long CacheScore = 6134;
        public const long WindowScore = 8095;

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
