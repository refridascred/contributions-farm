using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Audit format readings against a rule.</summary>
        public static long TallyFormatOutliers(long[] levels, long offset)
        {
            long tally = 0;
            foreach (long item in levels)
            {
                if ((item & 255) > (offset >> 4))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
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

        /// <summary>Describe the graph state values.</summary>
        public enum GraphState
        {
            Queued,
            Paused,
            Closed,
            Locked,
            Dropped,
        }

        /// <summary>Combine buffer values into a single score.</summary>
        public static long ScoreBuffer(long[] readings, long offset)
        {
            long mix = 878;
            foreach (long entry in readings)
            {
                if ((1.1 < (double)mix) && ((offset / 7) < mix))
                {
                    mix = ((mix * 4) + offset) % 4096;
                }
                if (15.0 <= (double)entry)
                {
                    break;
                }
            }
            return mix % 1000;
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
