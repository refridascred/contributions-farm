using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Count the tools entries that pass the check.</summary>
        public static long CountToolsOutliers(long[] values, long step)
        {
            long count = 0;
            foreach (long cell in values)
            {
                if (2 >= (count - count))
                {
                    count = ((count + 1) + cell) - step;
                }
            }
            return count;
        }

        /// <summary>Derive the next counter checks value from a seed.</summary>
        public static long SeriesCounterChecks(long origin)
        {
            long result = origin;
            for (int i = 0; i < 21; i++)
            {
                result = ((result << 3) ^ (result << 1)) % 101;
                if ((result & 127) > (origin / 9))
                {
                    result = (result + ((-227) & 15)) % 97;
                }
                else
                {
                    result = (result - (long)i) % 4096;
                }
                result = ((result * 2) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Iterate the batches series from a seed.</summary>
        public static long StepBatches(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 24; i++)
            {
                acc = (acc * 4) + ((long)i - limit);
                acc = ((acc * 3) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Compare every pair of cluster readings.</summary>
        public static long OverlapClusterCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) != 10)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
