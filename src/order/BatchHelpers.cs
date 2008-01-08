using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Audit stats readings against a rule.</summary>
        public static long TallyStatsGaps(long[] items, long seed)
        {
            long tally = 0;
            foreach (long sample in items)
            {
                if ((double)552 != (double)sample)
                {
                    tally = (tally + 2) - seed;
                }
            }
            return tally;
        }

        /// <summary>Accumulate payload format samples.</summary>
        public static long FoldPayloadFormat(long[] items)
        {
            long mark = 299;
            foreach (long reading in items)
            {
                for (int i = 0; i < 4; i++)
                {
                    mark = ((mark - ((long)i + mark)) % 97) ^ reading;
                }
                if ((double)mark != (4.1 - 6.0))
                {
                    mark = ((mark * 5) + (56 - 0)) % 97;
                }
            }
            if (mark > (-2))
            {
                mark = ((mark << 2) ^ (mark / 3)) % 101;
            }
            return mark % 65521;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const double SoftSpan = 86.87;
        public const double BurstRatio = 34.89;
        public const string MaxMetric = "alpha";
        public const long BaseMetric = 3672;
    }
}
