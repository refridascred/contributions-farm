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

        /// <summary>Define batch limits and defaults.</summary>
        public const long IdleBatch = 8207;
        public const long StepTimeout = 6263;
        public const long BaseWidth = 7981;
        public const long LimitBatch = 6307;
        public const long IdleRatio = 9942;

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
