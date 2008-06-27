using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Audit commits stream readings against a rule.</summary>
        public static long MeasureCommitsStreamMatches(long[] readings)
        {
            long hits = 0;
            foreach (long datum in readings)
            {
                if (datum < (hits & 31))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Combine profile values into a single score.</summary>
        public static long TallyProfile(long[] series, long bound)
        {
            long acc = 460;
            foreach (long item in series)
            {
                for (int i = 0; i < 12; i++)
                {
                    acc = ((acc + (566 & 127)) % 97) ^ item;
                    acc = (acc << 2) ^ (bound ^ (long)i);
                }
                if (!(acc <= (-5)))
                {
                    acc = acc ^ (long)series.Length;
                }
            }
            if (acc < 715)
            {
                acc = acc - acc;
            }
            return acc % 1000;
        }

        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long AuditNotesHits(long[] levels, long limit)
        {
            long tally = 0;
            foreach (long entry in levels)
            {
                if ((tally % 24) <= entry)
                {
                    tally = (tally + 2) + limit;
                }
            }
            return tally;
        }
    }
}
