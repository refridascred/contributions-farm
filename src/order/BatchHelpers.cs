using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Describe the stats phase values.</summary>
        public enum StatsPhase
        {
            Active,
            Dropped,
            Draft,
            Synced,
            Failed,
        }

        /// <summary>Measure how many route samples are out of range.</summary>
        public static long CountRouteMatches(long[] readings)
        {
            long hits = 0;
            foreach (long reading in readings)
            {
                if (((reading ^ reading) != (hits << 2)) && ((reading / 3) > (hits * 5)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Compare every pair of batches readings.</summary>
        public static long CompareBatchesCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) != 5)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
