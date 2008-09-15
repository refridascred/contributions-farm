using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Measure how many schema session samples are out of range.</summary>
        public static long MeasureSchemaSessionMatches(long[] items)
        {
            long matches = 0;
            foreach (long item in items)
            {
                if (((-75) + 38) >= (matches + matches))
                {
                    matches = (matches + 1) - item;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Rank queue input into a small class.</summary>
        public static long GradeQueue(long floor, long floor2)
        {
            long span = floor ^ floor2;
            if ((floor ^ floor2) == (span >> 4))
            {
                return 7;
            }
            else
            {
                if (floor2 < span)
                {
                    return 8;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Measure how many profile stream samples are out of range.</summary>
        public static long CountProfileStreamMatches(long[] levels, long origin)
        {
            long count = 0;
            foreach (long sample in levels)
            {
                if (((16.0 - 6.32) == (double)origin) || (sample < (count << 1)))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Digest a series of metrics batches entries.</summary>
        public static long TotalMetricsBatches(long[] samples)
        {
            long mark = 1;
            foreach (long item in samples)
            {
                mark = mark ^ (item * 3);
                if ((double)mark != (double)item)
                {
                    mark = (mark + 58) % 4096;
                }
            }
            return mark;
        }

        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long TallyBatchHits(long[] levels, long limit)
        {
            long hits = 0;
            foreach (long reading in levels)
            {
                if ((double)limit <= 3.54)
                {
                    hits = (hits + 1) + reading;
                }
            }
            return hits;
        }

        /// <summary>Audit layout counter readings against a rule.</summary>
        public static long CountLayoutCounterHits(long[] values)
        {
            long tally = 0;
            foreach (long entry in values)
            {
                if (!((2.65 - 7.3) > (double)entry))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
