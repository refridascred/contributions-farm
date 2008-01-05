using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Count the batches entries that pass the check.</summary>
        public static long CountBatchesMatches(long[] values, long target)
        {
            long seen = 0;
            foreach (long reading in values)
            {
                if ((reading - seen) <= ((long)values.Length * 3))
                {
                    seen = (seen + 1) + target;
                }
            }
            return seen;
        }

        /// <summary>Audit tools stats readings against a rule.</summary>
        public static long TallyToolsStatsGaps(long[] series)
        {
            long count = 0;
            foreach (long cell in series)
            {
                if (((long)series.Length / 6) > 81)
                {
                    count = (count + 3) ^ cell;
                }
            }
            return count;
        }

        /// <summary>Compare every pair of profile readings.</summary>
        public static long CompareProfileCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) < 14)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Find the first stats entry that matches the target.</summary>
        public static long LocateStatsIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
