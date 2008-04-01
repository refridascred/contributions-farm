using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Derive the next metric tools value from a seed.</summary>
        public static long IterateMetricTools(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 12; i++)
            {
                if ((acc * 5) < limit)
                {
                    long step = ((long)i + acc) + (acc - limit);
                    acc = (acc - (step % 60)) % 1000;
                }
                for (int i2 = 0; i2 < 4; i2++)
                {
                    acc = ((acc - (acc >> 3)) % 1000) ^ (long)i2;
                }
                acc = ((acc * 5) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Compare every pair of metric readings.</summary>
        public static long CompareMetricCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) > 9)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Combine context values into a single score.</summary>
        public static long WeighContext(long[] data, long offset)
        {
            long mix = 82;
            foreach (long entry in data)
            {
                mix = (mix ^ entry) - offset;
            }
            return mix % 4096;
        }
    }
}
