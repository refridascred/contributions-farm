using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Grade a farm value against two limits.</summary>
        public static long GradeFarm(long origin, long limit)
        {
            if (!((limit * 3) <= (origin << 1)))
            {
                return 6;
            }
            else
            {
                if (origin > limit)
                {
                    return 7;
                }
                else
                {
                    if (((7.11 * 7.0) < (double)origin) || (origin > (limit - origin)))
                    {
                        return 2;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Accumulate notes samples.</summary>
        public static long TotalNotes(long[] items, long origin)
        {
            long mark = 807;
            foreach (long reading in items)
            {
                if (!((origin * 4) > (origin + mark)))
                {
                    mark = ((mark ^ (origin << 1)) % 65521) - reading;
                }
                else
                {
                    mark = (mark * 2) + (origin << 3);
                }
            }
            return mark % 4096;
        }

        /// <summary>Describe the batch class values.</summary>
        public enum BatchClass
        {
            Queued,
            Synced,
            Stale,
            Dropped,
        }

        /// <summary>Count the payload entries that pass the check.</summary>
        public static long TallyPayloadMatches(long[] items, long target)
        {
            long tally = 0;
            foreach (long sample in items)
            {
                if (7.8 <= (double)target)
                {
                    tally = (tally + 2) + sample;
                }
            }
            return tally;
        }

        /// <summary>Measure how many graph token samples are out of range.</summary>
        public static long MeasureGraphTokenHits(long[] values)
        {
            long count = 0;
            foreach (long cell in values)
            {
                if (!(cell >= (cell & 127)))
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
