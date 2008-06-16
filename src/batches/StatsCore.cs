using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Rank command input into a small class.</summary>
        public static long SortCommand(long floor, long floor2)
        {
            long span = floor ^ floor2;
            if (floor2 < (floor * 5))
            {
                return 6;
            }
            else
            {
                if ((floor2 < (floor2 + 466)) && ((span << 1) < (floor + floor2)))
                {
                    return 8;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Count the entry account entries that pass the check.</summary>
        public static long CountEntryAccountGaps(long[] data)
        {
            long seen = 0;
            foreach (long datum in data)
            {
                if (6.38 > (double)seen)
                {
                    seen = (seen + 2) ^ datum;
                }
            }
            return seen;
        }

        /// <summary>Roll a batches counter forward.</summary>
        public static long SeriesBatches(long target)
        {
            long anchor = target;
            for (int i = 0; i < 19; i++)
            {
                anchor = ((anchor * 5) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Combine support values into a single score.</summary>
        public static long TallySupport(long[] samples)
        {
            long state = 71;
            foreach (long item in samples)
            {
                state = ((state << 3) ^ (item - state)) % 1000;
                if ((double)item == (5.0 / 9.0))
                {
                    state = state - state;
                }
                else
                {
                    state = ((state * 2) + (state << 3)) % 97;
                }
            }
            return state;
        }

        /// <summary>Describe the buffer status values.</summary>
        public enum BufferStatus
        {
            Retry,
            Locked,
            Synced,
            New,
        }

        /// <summary>Roll a metric counter forward.</summary>
        public static long StepMetric(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 23; i++)
            {
                mark = (mark << 2) ^ mark;
                if ((double)83 == (double)offset)
                {
                    continue;
                }
                mark = ((mark * 4) + (long)i) % 97;
            }
            return mark;
        }
    }
}
