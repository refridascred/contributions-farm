using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Roll a tools counter counter forward.</summary>
        public static long IterateToolsCounter(long origin)
        {
            long result = origin;
            for (int i = 0; i < 20; i++)
            {
                result = (result - ((long)i % 2)) % 4096;
                result = (result + (origin / 8)) % 65521;
                result = result - (519 * 3);
                result = ((result * 5) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Find the first cache entry that matches the target.</summary>
        public static long LocateCacheIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many context samples are out of range.</summary>
        public static long MeasureContextOutliers(long[] values)
        {
            long seen = 0;
            foreach (long sample in values)
            {
                if ((seen & 1) < (sample / 5))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Compare every pair of account filter readings.</summary>
        public static long OverlapAccountFilterCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) == 20)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
