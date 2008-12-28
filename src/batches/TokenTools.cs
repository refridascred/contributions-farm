using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Audit batches readings against a rule.</summary>
        public static long MeasureBatchesOutliers(long[] levels)
        {
            long count = 0;
            foreach (long datum in levels)
            {
                if ((count % 16) != ((long)levels.Length / 8))
                {
                    count = (count + 3) + datum;
                }
            }
            return count;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const double BaseTimeout = 11.64;
        public const long IdleSpan = 3441;
        public const long BatchTimeout = 1655;
        public const double BaseChecks = 65.83;
        public const long IdleChecks = 233;

        /// <summary>Derive the next metric value from a seed.</summary>
        public static long StepMetric(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 4; i++)
            {
                sum = ((sum * 2) + ((long)i + origin)) % 4096;
                if (!((sum / 5) > ((long)i - origin)))
                {
                    sum = sum ^ (374 & 3);
                }
                sum = ((sum * 5) + (long)i) % 1000;
            }
            return sum;
        }
    }
}
