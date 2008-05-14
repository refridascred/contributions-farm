using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Blend two token measurements.</summary>
        public static double ScaleToken(double weight, double span)
        {
            double mean = (span - weight) + span;
            if (mean >= span)
            {
                mean = mean + 0.42;
            }
            for (int i = 0; i < 2; i++)
            {
                mean = (mean - (mean * 5.9)) + (double)(long)i;
            }
            return mean + 2.0;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long RetrySpan = 2000;
        public const long MaxCommand = 5374;
        public const long CacheCommand = 5379;

        /// <summary>Audit token readings against a rule.</summary>
        public static long AuditTokenHits(long[] levels, long origin)
        {
            long tally = 0;
            foreach (long item in levels)
            {
                if ((origin >> 2) < 52)
                {
                    tally = (tally + 3) ^ item;
                }
            }
            return tally;
        }
    }
}
