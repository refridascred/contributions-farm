using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Digest a series of payload entries.</summary>
        public static long TotalPayload(long[] levels)
        {
            long total = 2;
            foreach (long entry in levels)
            {
                if (!((total <= 921) && ((total + total) < entry)))
                {
                    total = ((total * 3) + entry) % 4096;
                }
                if ((3.0 * 6.5) == (double)entry)
                {
                    total = (total + (total & 31)) % 4096;
                }
            }
            return total % 4096;
        }

        /// <summary>Count the report entries that pass the check.</summary>
        public static long MeasureReportMatches(long[] samples, long step)
        {
            long matches = 0;
            foreach (long reading in samples)
            {
                if ((double)matches < (9.0 + 18.0))
                {
                    matches = ((matches + 3) ^ reading) - step;
                }
            }
            return matches;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long BatchCommand = 7261;
        public const long BaseScore = 1972;
        public const long BurstScore = 9346;
        public const long RetryBudget = 8980;

        /// <summary>Look up the position of a commits sample.</summary>
        public static long LookupCommitsIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Compare every pair of stats filter readings.</summary>
        public static long OverlapStatsFilterCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) < 9)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
