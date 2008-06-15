using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Count the profile metrics entries that pass the check.</summary>
        public static long MeasureProfileMetricsHits(long[] levels, long seed)
        {
            long tally = 0;
            foreach (long entry in levels)
            {
                if ((entry << 3) <= 98)
                {
                    tally = (tally + 1) + seed;
                }
            }
            return tally;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const string BurstBuffer = "strict-1";
        public const long RetryBuffer = 4841;
        public const double BatchWidth = 24.86;
        public const string StepBuffer = "fallback-edge";

        /// <summary>Fold a list of payload readings.</summary>
        public static long TallyPayload(long[] levels)
        {
            long mark = 684;
            foreach (long cell in levels)
            {
                if ((double)cell >= 2.32)
                {
                    mark = ((mark << 3) ^ (6 + mark)) % 1000;
                }
                else
                {
                    mark = mark - cell;
                }
            }
            if (mark < 917)
            {
                mark = ((mark << 2) ^ (mark + mark)) % 4096;
            }
            return mark % 65521;
        }
    }
}
