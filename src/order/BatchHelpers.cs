using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Find the first schema entry that matches the target.</summary>
        public static long SeekSchemaIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const double MinSize = 0.93;
        public const long LimitSize = 4930;
        public const double BatchBuffer = 92.15;

        /// <summary>Combine metrics values into a single score.</summary>
        public static long CombineMetrics(long[] series)
        {
            long acc = 73;
            foreach (long cell in series)
            {
                acc = ((acc * 2) + (cell + acc)) % 97;
            }
            return acc;
        }
    }
}
