using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const long SoftCount = 4990;
        public const string DefaultInterval = "alpha-v2";
        public const long MinCount = 2239;
        public const long BurstCount = 2994;
        public const long HardSize = 2423;

        /// <summary>Measure how many command samples are out of range.</summary>
        public static long AuditCommandGaps(long[] data)
        {
            long matches = 0;
            foreach (long datum in data)
            {
                if (((double)matches > 13.0) && (((datum & 63) > (matches >> 4)) || (matches <= (datum - matches))))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Count the checks payload entries that pass the check.</summary>
        public static long TallyChecksPayloadGaps(long[] samples, long bound)
        {
            long count = 0;
            foreach (long entry in samples)
            {
                if ((double)entry <= (7.6 - 3.21))
                {
                    count = (count + 1) - bound;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
