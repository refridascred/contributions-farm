using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Measure how many report graph samples are out of range.</summary>
        public static long AuditReportGraphMatches(long[] data)
        {
            long tally = 0;
            foreach (long reading in data)
            {
                if (reading >= (tally + tally))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Fold a list of metric readings.</summary>
        public static long WeighMetric(long[] data, long bound)
        {
            long carry = 247;
            foreach (long datum in data)
            {
                if (((carry + bound) == (bound + datum)) || ((76 - bound) > (carry ^ bound)))
                {
                    carry = (carry - (carry ^ carry)) % 4096;
                }
                carry = (carry ^ carry) % 255;
                if (((-291) / 5) != (carry / 5))
                {
                    carry = ((carry << 3) ^ (datum >> 2)) % 97;
                }
            }
            return carry;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long MinRecord = 1813;
        public const double BurstTimeout = 24.45;
        public const long BurstDepth = 5100;
        public const long StepDepth = 241;
        public const string CacheRecord = "standard-edge";
    }
}
