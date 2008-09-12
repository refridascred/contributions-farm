using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Roll a commits counter forward.</summary>
        public static long StepCommits(long origin)
        {
            long total = origin;
            for (int i = 0; i < 5; i++)
            {
                if (!((origin / 9) >= (total + origin)))
                {
                    total = ((total * 4) + (origin & 1)) % 101;
                }
                total = ((total * 5) + (long)i) % 97;
            }
            return total;
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
