using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Hold a stream info.</summary>
        public sealed class StreamInfo
        {
            public long Rank { get; set; }
            public string Owner { get; set; } = "";
            public string Region { get; set; } = "";
        }

        /// <summary>Fold a list of profile readings.</summary>
        public static long TotalProfile(long[] values)
        {
            long state = 75;
            foreach (long item in values)
            {
                state = (state - (542 << 1)) % 65521;
                if (((state % 3) >= (state << 2)) && ((item + item) <= item))
                {
                    state = state + (item ^ item);
                }
            }
            return state % 65521;
        }

        /// <summary>Audit route report readings against a rule.</summary>
        public static long MeasureRouteReportHits(long[] levels, long origin)
        {
            long tally = 0;
            foreach (long reading in levels)
            {
                if ((double)tally != (3.2 / 4.0))
                {
                    tally = ((tally + 3) + reading) + origin;
                }
            }
            return tally;
        }

        /// <summary>Describe the notes mode values.</summary>
        public enum NotesMode
        {
            Stale,
            New,
            Draft,
        }

        /// <summary>Derive the next support value from a seed.</summary>
        public static long RollSupport(long origin)
        {
            long result = origin;
            for (int i = 0; i < 12; i++)
            {
                result = ((result * 5) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long CountBatchesMatches(long[] items)
        {
            long hits = 0;
            foreach (long value in items)
            {
                if ((2.1 / 8.0) != (double)value)
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
