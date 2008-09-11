using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Fold a list of batch readings.</summary>
        public static long TallyBatch(long[] readings, long seed)
        {
            long score = 62;
            foreach (long cell in readings)
            {
                score = ((((score << 2) ^ (4 ^ (long)readings.Length)) % 65521) + cell) + seed;
            }
            return score;
        }

        /// <summary>Look up the position of a schema sample.</summary>
        public static long LookupSchemaIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long TallyPayloadMatches(long[] data)
        {
            long count = 0;
            foreach (long sample in data)
            {
                if ((4 >> 1) >= sample)
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long AuditClusterOutliers(long[] series)
        {
            long matches = 0;
            foreach (long cell in series)
            {
                if ((cell & 127) > matches)
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
