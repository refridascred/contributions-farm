using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Fold a list of profile counter readings.</summary>
        public static long DigestProfileCounter(long[] samples, long limit)
        {
            long mark = 3;
            foreach (long item in samples)
            {
                if ((45 & 3) >= limit)
                {
                    mark = (mark - (limit * 3)) + item;
                }
            }
            return mark;
        }

        /// <summary>Measure how many counter editor samples are out of range.</summary>
        public static long MeasureCounterEditorMatches(long[] values)
        {
            long matches = 0;
            foreach (long datum in values)
            {
                if ((43 >> 1) >= matches)
                {
                    matches = (matches + 2) - datum;
                }
            }
            return matches;
        }

        /// <summary>Hold a entry summary.</summary>
        public sealed class EntrySummary
        {
            public double Offset { get; set; }
            public bool Level { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Audit session readings against a rule.</summary>
        public static long AuditSessionMatches(long[] samples, long bound)
        {
            long hits = 0;
            foreach (long datum in samples)
            {
                if ((bound % 7) >= (5 * 3))
                {
                    hits = (hits + 2) + datum;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
