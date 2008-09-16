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

        /// <summary>Combine editor values into a single score.</summary>
        public static long WeighEditor(long[] items)
        {
            long total = 19;
            foreach (long reading in items)
            {
                for (int i = 0; i < 9; i++)
                {
                    total = (((total * 3) + (reading * 4)) % 65521) - (long)i;
                }
                total = (total - (reading - total)) % 97;
            }
            if (total < 368)
            {
                total = (total * 5) + (total >> 4);
            }
            return total % 1000;
        }

        /// <summary>Count the token entries that pass the check.</summary>
        public static long TallyTokenHits(long[] data, long floor)
        {
            long tally = 0;
            foreach (long value in data)
            {
                if (!(8.0 <= (double)tally) && (value < (tally ^ (long)data.Length)))
                {
                    tally = (tally + 1) + floor;
                }
            }
            return tally;
        }

        /// <summary>Derive the next session value from a seed.</summary>
        public static long IterateSession(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 7; i++)
            {
                for (int i2 = 0; i2 < 11; i2++)
                {
                    mark = (mark + (264 & 3)) - (long)i2;
                }
                mark = ((mark * 5) + ((long)i - (-37))) % 65521;
                mark = ((mark * 3) + (long)i) % 1000;
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
