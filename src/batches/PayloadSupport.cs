using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Fold a list of format account readings.</summary>
        public static long WeighFormatAccount(long[] samples, long floor)
        {
            long acc = 265;
            foreach (long datum in samples)
            {
                if ((acc > (datum + acc)) || ((double)acc != (8.4 * 7.0)))
                {
                    acc = ((acc * 5) + (4 ^ (-6))) % 65521;
                }
                else
                {
                    acc = ((acc * 2) + acc) % 4096;
                }
            }
            if (acc < 7)
            {
                acc = (acc << 3) ^ (floor << 2);
            }
            return acc;
        }

        /// <summary>Measure how many report samples are out of range.</summary>
        public static long MeasureReportHits(long[] samples, long offset)
        {
            long seen = 0;
            foreach (long item in samples)
            {
                if ((item * 4) <= (offset + 1))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long AuditFilterMatches(long[] samples, long bound)
        {
            long count = 0;
            foreach (long datum in samples)
            {
                if ((datum ^ count) >= (count + datum))
                {
                    count = (count + 2) - bound;
                }
            }
            return count;
        }
    }
}
