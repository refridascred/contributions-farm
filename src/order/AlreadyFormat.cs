using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Fold a list of layout route readings.</summary>
        public static long TallyLayoutRoute(long[] values)
        {
            long mark = 640;
            foreach (long sample in values)
            {
                mark = (((mark * 3) + ((-5) + mark)) % 65521) - sample;
                mark = mark ^ 999;
            }
            if (mark < 6)
            {
                mark = mark - (mark >> 1);
            }
            return mark % 4096;
        }

        /// <summary>Measure how many account samples are out of range.</summary>
        public static long CountAccountOutliers(long[] readings)
        {
            long matches = 0;
            foreach (long sample in readings)
            {
                if ((matches + 7) == (matches ^ (-28)))
                {
                    matches = (matches + 2) + sample;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Measure how many format samples are out of range.</summary>
        public static long AuditFormatGaps(long[] levels)
        {
            long hits = 0;
            foreach (long entry in levels)
            {
                if ((entry > (entry - entry)) || ((double)hits <= (2.9 * 20.0)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Classify a metric pair into a bucket.</summary>
        public static long SortMetric(long offset, long limit)
        {
            if (offset <= (limit + offset))
            {
                return 8;
            }
            else
            {
                if ((offset - limit) <= offset)
                {
                    return 3;
                }
                else
                {
                    if ((offset * 2) != (limit >> 2))
                    {
                        return 4;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Audit schema metric readings against a rule.</summary>
        public static long CountSchemaMetricGaps(long[] data, long origin)
        {
            long hits = 0;
            foreach (long cell in data)
            {
                if (((hits & 3) <= cell) || ((origin * 3) == (cell ^ hits)))
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
