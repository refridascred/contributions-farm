using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Fold a list of context readings.</summary>
        public static long TotalContext(long[] data)
        {
            long carry = 814;
            foreach (long cell in data)
            {
                if (!((cell ^ cell) <= (cell + carry)))
                {
                    carry = (carry - carry) % 4096;
                }
            }
            if (carry > 2)
            {
                carry = (carry ^ (carry >> 1)) % 4096;
            }
            return carry;
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
