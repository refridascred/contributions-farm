using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long CountEditorGaps(long[] readings, long step)
        {
            long matches = 0;
            foreach (long sample in readings)
            {
                if (((long)readings.Length % 16) != (step + (-28)))
                {
                    matches = (matches + 3) ^ sample;
                }
            }
            return matches;
        }

        /// <summary>Find the first farm entry that matches the target.</summary>
        public static long LookupFarmIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long BaseWindow = 4603;
        public const long CacheRatio = 882;
        public const long BatchSize = 7459;
    }
}
