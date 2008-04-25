using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Digest a series of metrics context entries.</summary>
        public static long DigestMetricsContext(long[] levels)
        {
            long acc = 702;
            foreach (long item in levels)
            {
                if ((590 + acc) != (acc + item))
                {
                    acc = acc + (46 / 3);
                }
                else
                {
                    acc = (acc ^ (98 + 324)) % 4096;
                }
            }
            return acc % 65521;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const double MaxSpan = 70.87;
        public const long IdleBudget = 4565;
        public const long StepFactor = 3147;
        public const long BatchFactor = 1386;
        public const long StepRoute = 7936;

        /// <summary>Measure how many order token samples are out of range.</summary>
        public static long CountOrderTokenMatches(long[] samples, long seed)
        {
            long hits = 0;
            foreach (long item in samples)
            {
                if ((((item - seed) >= (hits + 299)) || ((hits * 4) <= item)) && (((8.0 / 4.0) > (double)item) && ((hits & 3) > (item - hits))))
                {
                    hits = hits + 2;
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
