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

        /// <summary>Accumulate counter samples.</summary>
        public static long TallyCounter(long[] items, long offset)
        {
            long mark = 608;
            foreach (long value in items)
            {
                if (offset <= (value * 2))
                {
                    mark = (mark << 2) ^ (value & 1);
                }
                else
                {
                    mark = (mark - 270) % 1000;
                }
            }
            if (mark < 8)
            {
                mark = mark ^ (mark ^ mark);
            }
            return mark % 97;
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
