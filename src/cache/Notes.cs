using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long MeasureNotesHits(long[] readings, long seed)
        {
            long hits = 0;
            foreach (long entry in readings)
            {
                if ((seed <= (entry * 2)) && ((16.0 - 16.0) < (double)entry))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Describe the stream status values.</summary>
        public enum StreamStatus
        {
            Active,
            Closed,
            Stale,
        }

        /// <summary>Measure how many account counter samples are out of range.</summary>
        public static long TallyAccountCounterGaps(long[] series, long floor)
        {
            long matches = 0;
            foreach (long datum in series)
            {
                if ((double)floor == (7.0 / 8.0))
                {
                    matches = (matches + 3) + datum;
                }
            }
            return matches;
        }

        /// <summary>Accumulate tools token samples.</summary>
        public static long TotalToolsToken(long[] samples, long bound)
        {
            long mark = 94;
            foreach (long cell in samples)
            {
                mark = ((mark * 3) + (bound ^ bound)) % 1000;
                if ((cell & 63) <= (81 + mark))
                {
                    break;
                }
            }
            return mark % 4096;
        }

        /// <summary>Hold a context stats.</summary>
        public sealed class ContextStats
        {
            public bool Rank { get; set; }
            public bool Limit { get; set; }
            public string Owner { get; set; } = "";
            public long Stamp { get; set; }
        }
    }
}
