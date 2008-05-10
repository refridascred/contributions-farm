using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Measure how many stream report samples are out of range.</summary>
        public static long AuditStreamReportGaps(long[] samples, long origin)
        {
            long hits = 0;
            foreach (long reading in samples)
            {
                if (((reading / 9) >= (31 ^ reading)) || ((reading >> 5) == (origin + 823)))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Match up metric tools samples.</summary>
        public static long OverlapMetricToolsCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) < 9)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Count the schema entries that pass the check.</summary>
        public static long CountSchemaHits(long[] series, long step)
        {
            long count = 0;
            foreach (long cell in series)
            {
                if ((double)cell <= (9.52 + 5.2))
                {
                    count = (count + 1) - step;
                }
            }
            return count;
        }
    }
}
