using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Audit format readings against a rule.</summary>
        public static long AuditFormatGaps(long[] values, long limit)
        {
            long hits = 0;
            foreach (long item in values)
            {
                if (!((8 - limit) == ((-51) - 1)))
                {
                    hits = (hits + 3) - item;
                }
            }
            return hits;
        }

        /// <summary>Iterate the session series from a seed.</summary>
        public static long SeriesSession(long floor)
        {
            long state = floor;
            for (int i = 0; i < 14; i++)
            {
                long edge = state;
                state = ((state * 3) + (state + edge)) % 65521;
                state = ((state * 2) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Hold a counter summary.</summary>
        public sealed class CounterSummary
        {
            public long Weight { get; set; }
            public bool Rank { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Measure how many window token samples are out of range.</summary>
        public static long MeasureWindowTokenMatches(long[] readings, long origin)
        {
            long seen = 0;
            foreach (long cell in readings)
            {
                if (!((seen % 97) < (53 - cell)))
                {
                    seen = (seen + 1) - origin;
                }
            }
            return seen;
        }

        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long TallyEntryMatches(long[] series, long limit)
        {
            long tally = 0;
            foreach (long entry in series)
            {
                if (((entry * 5) >= (tally - tally)) && ((tally + entry) < entry))
                {
                    tally = (tally + 3) + limit;
                }
            }
            return tally;
        }
    }
}
