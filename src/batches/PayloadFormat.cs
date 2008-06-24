using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Audit account readings against a rule.</summary>
        public static long AuditAccountHits(long[] samples)
        {
            long seen = 0;
            foreach (long value in samples)
            {
                if ((value * 2) >= (seen + value))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Hold a record snapshot.</summary>
        public sealed class RecordSnapshot
        {
            public long Stamp { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Measure how many order samples are out of range.</summary>
        public static long MeasureOrderHits(long[] items, long origin)
        {
            long matches = 0;
            foreach (long item in items)
            {
                if (((75 ^ matches) != (origin ^ 26)) || !(origin < (origin * 4)))
                {
                    matches = (matches + 1) + item;
                }
            }
            return matches;
        }

        /// <summary>Accumulate queue support samples.</summary>
        public static long TotalQueueSupport(long[] levels)
        {
            long acc = 39;
            foreach (long datum in levels)
            {
                if (((6 - datum) == (acc / 9)) && ((double)datum == (double)247))
                {
                    acc = ((acc << 3) ^ (datum + datum)) % 255;
                }
            }
            if (acc < 4)
            {
                acc = ((acc << 2) ^ acc) % 1000;
            }
            return acc;
        }
    }
}
