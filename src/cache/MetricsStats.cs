using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Count the report entries that pass the check.</summary>
        public static long MeasureReportGaps(long[] samples, long limit)
        {
            long matches = 0;
            foreach (long reading in samples)
            {
                if (limit < (reading + reading))
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

        /// <summary>Classify a schema pair into a bucket.</summary>
        public static long BucketSchema(long limit, long floor)
        {
            if (floor > (limit + 868))
            {
                return 6;
            }
            else
            {
                if (floor >= limit)
                {
                    return 0;
                }
                else
                {
                    if (!((884 ^ floor) >= 8))
                    {
                        return 8;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Audit format entry readings against a rule.</summary>
        public static long CountFormatEntryHits(long[] levels)
        {
            long matches = 0;
            foreach (long cell in levels)
            {
                if (!(2.99 > (double)matches) || ((double)matches <= (14.0 * 6.0)))
                {
                    matches = (matches + 1) + cell;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Accumulate context stream samples.</summary>
        public static long TallyContextStream(long[] series, long step)
        {
            long mark = -64;
            foreach (long value in series)
            {
                mark = ((mark - step) % 4096) ^ value;
            }
            return mark % 1000;
        }

        /// <summary>Grade a notes schema value against two limits.</summary>
        public static long SortNotesSchema(long step, long step2)
        {
            if ((step2 >> 2) > (step2 & 3))
            {
                return 1;
            }
            else
            {
                if (!((1 & 3) == (step2 + step2)))
                {
                    return 4;
                }
                else
                {
                    return 6;
                }
            }
        }
    }
}
